using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Hosting;
//using System.Web.Mvc;
using System.Xml.Linq;
using AetherPal.Control.Sys.Extensions.Xml;
using System.IO;
using AetherPal.Control.Sys.Utils;
using System.Globalization;
using System.Configuration;
using AetherPal.Control.Presentation.Localization;
using AetherPal.Control.Services.ServiceInterface.Localization;


namespace AetherPal.Control.Presentation.AnchorSite
{
    public class LocalizationModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += new System.EventHandler(context_PreRequestHandlerExecute);
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["lang"] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["lang"];
                string lang = "es-ES";// cookie.Value;
                var culture = new System.Globalization.CultureInfo(lang);
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
            }
        }

        void context_PreRequestHandlerExecute(object sender, System.EventArgs e)
        {
            string lang = "en-US"; 
            var cultureInfo = new CultureInfo(lang);
            try
            {
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "context_PreRequestHandlerExecute", "Init ");
                var userLanguages = HttpContext.Current.Request.UserLanguages;
                try
                {
                    lang = userLanguages[0];
                    cultureInfo = new CultureInfo((userLanguages != null
                               ? userLanguages[0] : "en-ES" )
                    );
                }
                catch (Exception ex)
                {
                    //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "context_PreRequestHandlerExecute", "Exception : " + ex.Message);
                    string cultureRule = GetExtensionCultureRule(lang);
                    if (cultureRule == null)
                        cultureRule = "en-US";
                    //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "context_PreRequestHandlerExecute", "Language Support : " + cultureRule);
                }
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "context_PreRequestHandlerExecute", "CurrentCulture : " + lang);
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "context_PreRequestHandlerExecute", "Language : " + cultureInfo.Name);
            }
            catch (Exception ex)
            {
                lang = "en-US";
                cultureInfo = new CultureInfo(lang);
            }
            //
            LocalizationPolicies globalPolicies = GetGlobalPolicies();
            if (globalPolicies != null)
            {
                string languagePath = GetLanguagePath(globalPolicies, cultureInfo.Name);
                LoadRemoteAssembly(cultureInfo.Name, languagePath);
            }
            else
            {
                DefaultAssembly();
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "DefaultAssembly", "Domain : " + DomainName);
            }
        }

        #region Extension Culture Rule - Venkat Changes

        internal static bool GetExtensionCultureRuleValue(string ExtensionDataRule, out string Key, out List<string> Values)
        {
            bool isGet = false;
            Key = null;
            Values = null;
            try
            {
                if (ExtensionDataRule.Contains(':'))
                {
                    string[] ExtensionDataRuleList = ExtensionDataRule.Split(':');
                    if (ExtensionDataRuleList.Length >= 2)
                    {
                        Key = ExtensionDataRuleList[0];
                        string Input = ExtensionDataRuleList[1];
                        Values = new List<string>();
                        string Value = Input;

                        if (Value.Contains(','))
                        {
                            string[] ValueList = Value.Split(',');
                            Values.AddRange(ValueList);
                        }
                        else
                        {
                            Values.Add(Value);
                        }
                        isGet = true;
                    }
                }
            }
            catch { }
            return isGet;
        }

        internal static string GetExtensionCultureRule(string attr)
        {
            string attributeRule = null;
            try
            {
                string ExtensionDataRule = ConfigurationManager.AppSettings["ExtensionCultureRule"];
                if (ExtensionDataRule.Contains(';'))
                {
                    string[] ExtensionDataRuleList = ExtensionDataRule.Split(';');
                    if (ExtensionDataRuleList.Length > 1)
                    {
                        foreach (string ruleName in ExtensionDataRuleList)
                        {
                            string Key = null;
                            List<string> Values = null;
                            if (GetExtensionCultureRuleValue(ruleName, out Key, out Values))
                            {
                                if (Values != null)
                                {
                                    foreach (string value in Values)
                                    {
                                        if (attr == value)
                                            attributeRule = Key;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    string Key = null;
                    List<string> Values = null;
                    if (GetExtensionCultureRuleValue(ExtensionDataRule, out Key, out Values))
                    {
                        if (Values != null)
                        {
                            foreach (string value in Values)
                            {
                                if (attr == value)
                                    attributeRule = Key;
                            }
                        }
                    }
                }
            }
            catch { attributeRule = attr; }
            return attributeRule;
        }

        #endregion

        public static bool IsRightToLeft()
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft;
        }

        public static Client Client
        {
            get
            {
                return GetClient(HttpContext.Current.Request.Url.Host);
            }
        }

        private static string DomainName
        {
            get
            {
                string domain;
                domain = HttpContext.Current.Request.Url.Host;
                return domain;
            }
        }

        private static string GLOBALVIRDIRECTORY
        {
            get
            {
                try
                {
                    string globalVirDir;
                    globalVirDir = System.Configuration.ConfigurationManager.AppSettings["GlobalVirDirectory"];
                    string globalDirectory = string.Format(globalVirDir, DomainName);
                    return globalDirectory;
                }
                catch { }
                return null;
            }
        }

        private static Client GetClient(string domainName)
        {
            Client client = null;
            try
            {
                string xmlPath = HostingEnvironment.ApplicationPhysicalPath + "App_Data\\Configuration.xml";
                var clientRoot = XDocument.Load(xmlPath).Root;
                domainName = "/" + domainName;

                var query = from p in clientRoot.Descendants("Client")
                            select new Client
                            {
                                IsDefault = p.Attribute("IsDefault").GetValue<bool>(),
                                Folder = p.Attribute("Folder").GetValue(),
                                DisplayName = p.Attribute("DisplayName").GetValue(),
                                Url = p.Attribute("Url").GetValue(),
                                ClientAppName = p.Attribute("ClientAppName").GetValue()
                            };

                foreach (Client local in query.ToList())
                {
                    if (local.IsDefault)
                    {
                        client = local;
                    }
                    if (local.Folder == domainName)
                    {
                        if (Directory.Exists(HostingEnvironment.ApplicationPhysicalPath + "Content" + local.Folder))
                        {
                            client = local;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "ClientObject", "Exception : " + ex.Message);

                if (client == null)
                {
                    client = new Client();
                    client.DisplayName = "AetherPal";
                    client.Url = "http://www.aetherpal.com";
                    client.Folder = "";
                    client.ClientAppName = "AetherPal!";
                }
            }
            return client;
        }

        #region Global

        private static LocalizationPolicies GetGlobalPolicies()
        {
            LocalizationPolicies gp = null;
            try
            {
                string tenantUuid;
                //bool validTenant = Helpers.DataTierHelper.IsTenantValid(HttpContext.Current.Request.Url.DnsSafeHost, out tenantUuid);
                //if (string.IsNullOrEmpty(tenantUuid))
                    tenantUuid = "00000000-0000-0000-0000-000000000000";
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "GetGlobalPolicies", "tenantUuid : " + tenantUuid);
                string policiespath = GLOBALVIRDIRECTORY + "/get/getuuid/?uuid=" + tenantUuid;
                //string policiespath = "https://qcddc.dev.aetherpal.com/intl/get/getuuid/?uuid=ae09d19e-7894-49e1-82ae-ffa3a693655e";
                string policyValue = LocalizeUtils.GetURLContents(new Uri(policiespath));

                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "GetGlobalPolicies", "Value : " + policyValue);
                if (policyValue != null)
                {
                    gp = XmlHelper.Deserialize<LocalizationPolicies>(policyValue);
                }
            }
            catch (Exception ex)
            {
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "GetGlobalPolicies", "Exception : " + ex.Message);
            }
            return gp;
        }

        private static string GetLanguagePath(LocalizationPolicies gPolicies, string culture)
        {
            string languagePath = null;
            LocalizationPolicies policies = gPolicies;
            if (policies != null)
            {
                if (policies.Policies != null)
                {
                    LocalizationPolicy gp = policies.Policies.FirstOrDefault();
                    if (gp != null)
                    {
                        if (gp.SupportedLanguages != null)
                        {
                            Language language = gp.SupportedLanguages.Language.Where(l => l.Culture == culture).DefaultIfEmpty(GetDefaultLanguage(gPolicies, true)).First();
                            if (language != null)
                            {
                                //languagePath = language.Value;                              
                                languagePath = "/utils/lib/Spanish.dll";
                            }
                        }
                    }
                }
            }
            //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "GetLanguagePath", "Path : " + languagePath);
            return languagePath;
        }

        private static Language GetDefaultLanguage(LocalizationPolicies gPolicies, bool isDefault)
        {
            Language language = null;
            LocalizationPolicies policies = gPolicies;
            if (policies != null)
            {
                if (policies.Policies != null)
                {
                    LocalizationPolicy gp = policies.Policies.FirstOrDefault();
                    if (gp != null)
                    {
                        if (gp.SupportedLanguages != null)
                        {
                            Language lang = gp.SupportedLanguages.Language.FirstOrDefault(l => l.isDefault == isDefault);
                            if (lang != null)
                            {
                                language = lang;
                            }
                        }
                    }
                }
            }
            return language;
        }

        private static bool LoadRemoteAssembly(string cultureValue, string languagePath)
        {
            try
            {

                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "LoadAssembly", "Path : " + GLOBALVIRDIRECTORY + languagePath);
                if (!LocalizationManager.Instance.CulturesToSupport.ContainsKey(new CultureInfo(cultureValue)))
                    LocalizationManager.Instance.CulturesToSupport.Add(new CultureInfo(cultureValue), LocalizeUtils.LoadRemoteAssembly(GLOBALVIRDIRECTORY + languagePath));
                LocalizationManager.Instance.CurrentCulture = new CultureInfo(cultureValue);
                return true;
            }
            catch (Exception ex)
            {
                DefaultAssembly();
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "LoadRuntimeAssembly", "Exception : " + ex.Message);
            }
            return false;
        }

        private static bool DefaultAssembly()
        {
            try
            {
                string cultureValue = "en-US";                
                if (!LocalizationManager.Instance.CulturesToSupport.ContainsKey(new CultureInfo(cultureValue)))
                    LocalizationManager.Instance.CulturesToSupport.Add(new CultureInfo(cultureValue), LocalizeUtils.LoadAssembly((typeof(ANCHOR_SITE))));
                LocalizationManager.Instance.CurrentCulture = new CultureInfo(cultureValue);
                return true;
            }
            catch (Exception ex)
            {
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "DefaultAssembly", "Exception : " + ex.Message);
            }
            return false;
        }

        public static string GetPropertyValue(string Key)
        {
            string propValue = null;
            try
            {
                propValue = LocalizationManager.Instance.GetPropertyValue(Key);
                if (string.IsNullOrEmpty(propValue))
                {
                    LocalizationPolicies globalPolicies = GetGlobalPolicies();
                    if (globalPolicies != null)
                    {
                        //string languagePath = GetLanguagePath(globalPolicies, "en-US");
                        //LoadRemoteAssembly("en-US", languagePath);
                        string languagePath = GetLanguagePath(globalPolicies, "en-ES");
                        LoadRemoteAssembly("en-ES", languagePath);
                    }
                    else
                        DefaultAssembly();

                    propValue = LocalizationManager.Instance.GetPropertyValue(Key);
                }
               // AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceInformation("LocalizationModule", "GetPropertyValue", "Key : " + Key + " Value : " + propValue);
            }
            catch (Exception ex)
            {
                //AetherPal.Control.Sys.Diagnostics.TraceUtils.TraceError("LocalizationModule", "GetPropertyValue", "Exception : " + ex.Message);
            }
            return propValue;
        }

        #endregion
    }
}