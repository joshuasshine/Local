using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace AetherPal.Control.Presentation.Localization
{
    public static class LocalizeUtils
    {
        public static Dictionary<string, ILocalize> LoadAssembly(string assemblyPath)
        {
            try
            {
                string assembly = System.IO.Path.GetFullPath(assemblyPath);
                byte[] bytesDLL = File.ReadAllBytes(assembly);
                Assembly ptrAssembly = AppDomain.CurrentDomain.Load(bytesDLL);

                if (ptrAssembly != null)
                {
                    Dictionary<string, ILocalize> localizedClasses = new Dictionary<string, ILocalize>();

                    foreach (Type item in ptrAssembly.GetTypes())
                    {
                        if (!item.IsClass) continue;
                        var interfaces = item.GetInterfaces();
                        if (interfaces != null && interfaces.Count() > 0 && interfaces.Contains(typeof(ILocalize)))
                        {
                            localizedClasses.Add(item.Name, (ILocalize)Activator.CreateInstance(item));
                        }
                    }

                    if (localizedClasses.Count > 0)
                        return localizedClasses;
                    else
                    {
                        Debug.WriteLine("LocalizeUtils.LoadAssembly assemblyPath: ", "Invalid DLL, Interface not found!");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.LoadAssembly : " + ex.Message);
                throw ex;
            }
            return null;
        }

        public static Dictionary<string, ILocalize> LoadRemoteAssembly(string assemblyPath)
        {
            try
            {
                byte[] assembly = Download(assemblyPath);
                Assembly ptrAssembly = Assembly.Load(assembly);

                Dictionary<string, ILocalize> localizedClasses = new Dictionary<string, ILocalize>();

                foreach (Type item in ptrAssembly.GetTypes())
                {
                    if (!item.IsClass) continue;
                    var interfaces = item.GetInterfaces();
                    if (interfaces != null && interfaces.Count() > 0 && interfaces.Contains(typeof(ILocalize)))
                    {
                        localizedClasses.Add(item.Name, (ILocalize)Activator.CreateInstance(item));
                    }
                }

                if (localizedClasses.Count > 0)
                    return localizedClasses;
                else
                {
                    System.Diagnostics.Debug.WriteLine("LocalizeUtils.LoadAssembly assemblyPath: ", "Invalid DLL, Interface not found!");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.LoadAssembly : " + ex.Message);
                throw ex;
            }
        }

        public static Dictionary<string, ILocalize> LoadAssembly(Type classType)
        {
            try
            {
                Assembly ptrAssembly = Assembly.GetAssembly(classType);
                Dictionary<string, ILocalize> localizedClasses = new Dictionary<string, ILocalize>();

                foreach (Type item in ptrAssembly.GetTypes())
                {
                    if (!item.IsClass) continue;
                    var interfaces = item.GetInterfaces();
                    if (interfaces != null && interfaces.Count() > 0 && interfaces.Contains(typeof(ILocalize)))
                        localizedClasses.Add(item.Name, (ILocalize)Activator.CreateInstance(item));
                }

                if (localizedClasses.Count > 0)
                    return localizedClasses;
                else
                {
                    Debug.WriteLine("LocalizeUtils.LoadAssembly classType: ", "Invalid DLL, Interface not found!");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.LoadAssembly: " + ex.Message);
                throw ex;
            }
        }

        public static string GetURLContents(Uri address)
        {
            string result = null;
            try
            {
                HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
                request.ContentType = "text/xml";
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.GetURLContents: " + ex.Message);
                throw ex;
            }
            return result;
        }

        public static int Download(String rFileName, String lFileName)
        {
            int pBytes = 0;
            Stream rStream = null;
            Stream lStream = null;
            WebResponse response = null;
            try
            {
                WebRequest request = WebRequest.Create(rFileName);
                if (request != null)
                {
                    response = request.GetResponse();
                    if (response != null)
                    {
                        rStream = response.GetResponseStream();
                        lStream = File.Create(lFileName);
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        do
                        {
                            bytesRead = rStream.Read(buffer, 0, buffer.Length);
                            lStream.Write(buffer, 0, bytesRead);
                            pBytes += bytesRead;
                        } while (bytesRead > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.GetURLContents: " + ex.Message);
                throw ex;
            }
            finally
            {
                if (response != null) response.Close();
                if (rStream != null) rStream.Close();
                if (lStream != null) lStream.Close();
            }
            return pBytes;
        }

        public static byte[] Download(string rFileName)
        {
            byte[] result = null;
            byte[] buffer = new byte[4096];

            try
            {
                WebRequest wr = WebRequest.Create(rFileName);
                using (WebResponse response = wr.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            int count = 0;
                            do
                            {
                                count = responseStream.Read(buffer, 0, buffer.Length);
                                memoryStream.Write(buffer, 0, count);
                            } while (count != 0);
                            result = memoryStream.ToArray();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.Download: " + ex.Message);
                throw ex;
            }
            return result;
        }

        public static DateTime GetLastModifiedTime(string uri)
        {
            DateTime lastModifiedTime = DateTime.Now;
            try
            {
                WebRequest req = HttpWebRequest.Create(uri);
                req.Method = "HEAD";
                using (WebResponse resp = req.GetResponse())
                {
                    string txt_lastModifiedTime = resp.Headers.Get("Last-Modified");
                    if (DateTime.TryParse(txt_lastModifiedTime, out lastModifiedTime))
                        return lastModifiedTime;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LocalizeUtils.GetLastModifiedTime : " + ex.Message);
                throw ex;
            }
            return lastModifiedTime;
        }
    }
}
