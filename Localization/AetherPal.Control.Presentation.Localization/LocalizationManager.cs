using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace AetherPal.Control.Presentation.Localization
{
    public class LocalizationManager
    {
        public event EventHandler<CultureEventArgs> CultureChanged;
        public Dictionary<CultureInfo, Dictionary<string, ILocalize>> CulturesToSupport { get; set; }
        public List<CultureInfo> SupportedCultures { get { return CulturesToSupport.Keys.ToList(); } }

        Dictionary<string, object> propValues = new Dictionary<string, object>();
        Dictionary<string, object> values_English = new Dictionary<string, object>();

        public Dictionary<string, object> PropValues
        {
            get { return propValues; }
        }

        #region SingleTon Instance
        private static LocalizationManager instance;
        public static LocalizationManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LocalizationManager();
                return instance;
            }
        }
        #endregion

        public LocalizationManager()
        {
            CulturesToSupport = new Dictionary<CultureInfo, Dictionary<string, ILocalize>>();
            CultureChanged += LocalizationManager_CultureChanged;
        }

        void LocalizationManager_CultureChanged(object sender, CultureEventArgs e)
        {
            propValues.Clear();
            foreach (KeyValuePair<string, ILocalize> obj in e.Localization)
                AssignPropertyValue(obj.Value, obj.Value.Type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.PropertyType == typeof(string)).ToArray());
        }

        public CultureInfo CurrentCulture
        {
            get { return CultureInfo.CurrentUICulture; }
            set
            {
                Thread.CurrentThread.CurrentUICulture = value;

                if (CultureChanged != null)
                {
                    var currentLocale = CulturesToSupport.FirstOrDefault(sl => sl.Key.Equals(value)).Value;
                    CultureChanged(this, new CultureEventArgs(value, currentLocale));
                }
            }
        }

        #region Helper

        void AssignPropertyValue(object classObject, PropertyInfo[] properties)
        {
            foreach (PropertyInfo p in properties)
                propValues.Add(p.Name, p.GetValue(classObject, null));
        }

        #endregion

        public void SetEnglishPropertiesValue(Dictionary<string, ILocalize> classList)
        {
            this.values_English = new Dictionary<string, object>();
            foreach (KeyValuePair<string, ILocalize> obj in classList)
                foreach (PropertyInfo p in obj.Value.Type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.PropertyType == typeof(string)).ToArray())
                    values_English.Add(p.Name, p.GetValue(obj.Value, null));
        }

        public string GetPropertyValue(string Key)
        {
            string value = propValues.FirstOrDefault(p => p.Key == Key).Value as string;
            if (string.IsNullOrEmpty(value)) value = values_English.FirstOrDefault(p => p.Key == Key).Value as string;
            return value;
        }
    }

    public class CultureEventArgs : EventArgs
    {
        public CultureEventArgs(CultureInfo culture, Dictionary<string, ILocalize> locale)
        {
            this.Culture = culture;
            this.Localization = locale;
        }

        public CultureInfo Culture { get; private set; }
        public Dictionary<string, ILocalize> Localization { get; private set; }
    }
}
