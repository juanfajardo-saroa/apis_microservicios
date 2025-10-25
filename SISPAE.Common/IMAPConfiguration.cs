/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>
//  
//   Rebex Sample Code License
// 


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SISPAE.Common
{
    /// <summary>
    /// Class for easier access to configuration values.
    /// </summary>
    public class IMAPConfiguration
    {

        private string _singleSignOn;
        private string _Exclusiones;
        private string _port;
        private string _userName;
        private string _protocol;
        private string _server;
        private string _Filtros;
        private string _suite;
        private string _security;
        private string _password;


        /// <summary>
        /// Gets an Int32 value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">Default value.</param>
        /// <returns>An Int32 value from the configuration.</returns>
        public int GetInt32(string key, int defaultValue)
        {
            try
            {
                string val = GetString(key);
                if (val == null)
                    return defaultValue;
                return Convert.ToInt32(val);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Gets the Int32 value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>An Int32 value from the configuration.</returns>
        public int GetInt32(string key)
        {
            return (int)GetValue(key, typeof(int));
        }

        /// <summary>
        /// Gets an Boolean value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">Default value.</param>
        /// <returns>An Boolean value from the configuration.</returns>
        public bool GetBoolean(string key, bool defaultValue)
        {
            try
            {
                string val = GetString(key);
                if (val == null)
                    return defaultValue;
                return Convert.ToBoolean(val);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Gets the string value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>An string value from the configuration.</returns>
        public string GetString(string key, string defaultValue)
        {
            object o = GetValue(key, typeof(string));

            if (o == null)
                return defaultValue;
            else
                return o.ToString();
        }

        /// <summary>
        /// Gets the string value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>An string value from the configuration.</returns>
        public string GetString(string key)
        {
            return GetString(key, null);
        }

        /// <summary>
        /// Gets the object value from the configuration.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="type">The type.</param>
        /// <returns>Value read from the configuration.</returns>
        public object GetValue(string key, Type type)
        {
            if (key == null)
                throw new ArgumentNullException();

            if (_table == null)
                Load2();

            if (type.IsEnum)
            {
                if (_table[key] == null)
                    return Enum.Parse(type, "0");
                return Enum.Parse(type, _table[key].ToString(), true);
            }

            if (_table[key] == null)
                return null;

            if (IsSerializable(type))
            {
                string value = _table[key].ToString();
                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(value)))
                {
                    try { return Formatter.Deserialize(stream); }
                    catch { return null; }
                }
            }
            else
            {
                return Convert.ChangeType(_table[key], type);
            }
        }

        /// <summary>
        /// Sets the configuration value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        public void SetValue(string key, object val)
        {
            if (key == null)
                throw new ArgumentNullException();

            if (_table == null)
                Load2();

            if (val != null)
            {
                Type type = val.GetType();
                if (type.IsEnum)
                    val = Convert.ChangeType(val, Enum.GetUnderlyingType(type));
                else if (IsSerializable(type))
                    val = ValueToString(val);
            }

            _table[key] = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IMAPConfiguration"/> class.
        /// </summary>
        /// <param name="filename">The filename where configuration is stored.</param>
        public IMAPConfiguration(string singleSignOn, string Exclusiones, string port, string userName, string protocol, string server, string Filtros,
                                 string suite, string security, string password)
        {
    
            _singleSignOn = singleSignOn;
            _Exclusiones = Exclusiones;
            _port = port;
            _userName = userName;
            _protocol = protocol;
            _server = server;
            _Filtros = Filtros;
            _suite = suite;
            _security = security;
            _password = password;
        }

        /// <summary>
        /// Saves the configuration values to file.
        /// </summary>
        public void Save()
        {
            if (_table == null)
                Load2();

            XmlDocument xml = new XmlDocument();
            XmlElement config = xml.CreateElement("configuration");
            xml.AppendChild(config);

            if (_table.Count == 0)
                return;

            IDictionaryEnumerator e = _table.GetEnumerator();

            while (e.MoveNext())
            {
                XmlElement key = xml.CreateElement("key");
                config.AppendChild(key);
                XmlAttribute atrName = xml.CreateAttribute("name");
                atrName.Value = e.Key.ToString();
                XmlAttribute atrVal = xml.CreateAttribute("value");
                atrVal.Value = ValueToString(e.Value);
                key.Attributes.Append(atrName);
                key.Attributes.Append(atrVal);
            }

            string configPath = Path.GetDirectoryName(_filename);
            if (!Directory.Exists(configPath))
                Directory.CreateDirectory(configPath);
            xml.Save(_filename);
        }

        #region Private attributes

        /// <summary>
        /// Filename for I/O operations
        /// </summary>
        private string _filename = null;

        /// <summary>
        /// Hashtable for inmemory config values storage
        /// </summary>
        private Hashtable _table = null;

        private BinaryFormatter _formatter = null;
        private BinaryFormatter Formatter
        {
            get
            {
                if (_formatter == null)
                    _formatter = new BinaryFormatter();
                return _formatter;
            }
        }

        #endregion

        #region  Private methods
        /// <summary>
        /// Gets a value indicationg whether the type is serializable or not.
        /// </summary>
        /// <param name="type">System.Type object.</param>
        /// <returns>True if the type is serializable; false otherwise.</returns>
        private bool IsSerializable(Type type)
        {
            // strings and value types are consider as not serializable for this purpose
            return !type.IsValueType &&
                type != typeof(string) &&
                (type.Attributes & System.Reflection.TypeAttributes.Serializable) > 0;
        }

        /// <summary>
        /// Gets a string representation of the value.
        /// </summary>
        /// <remarks>If value is serializable object, it returns Base64 string.</remarks>
        /// <param name="value">Value to be represent as a string.</param>
        /// <returns>String representation of the given value.</returns>
        private string ValueToString(object value)
        {
            if (IsSerializable(value.GetType()))
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    Formatter.Serialize(stream, value);
                    return Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length);
                }
            }
            return value.ToString();
        }

        /// <summary>
        /// Loads the configuration from the file.
        /// </summary>
        private void Load()
        {
            XmlDocument xml = new XmlDocument();

            if (_table == null)
                _table = new Hashtable();

            if (!File.Exists(_filename))
                return;

            if (_table != null)
                _table.Clear();

            xml.Load(_filename);

            XmlElement config = xml["configuration"];

            foreach (XmlNode key in config.ChildNodes)
            {
                string item = null;
                string name = null;

                if (key.Attributes["value"] != null)
                    item = key.Attributes["value"].Value;
                if (key.Attributes["name"] != null)
                    name = key.Attributes["name"].Value;
                if (key["value"] != null)
                    item = key["value"].InnerText;
                if (key["name"] != null)
                    name = key["name"].InnerText;

                if (name == null)
                    continue;

                if (item == null)
                    item = "";

                _table.Add(name, item);
            }
        }

        private void Load2()
        {

            if (_table == null)
                _table = new Hashtable();

            if (_table.Count>0)
                _table.Clear();

            _table.Add("singleSignOn", _singleSignOn);
            _table.Add("Exclusiones", _Exclusiones);
            _table.Add("port", _port);
            _table.Add("userName", _userName);
            _table.Add("protocol", _protocol);
            _table.Add("server", _server);
            _table.Add("Filtros", _Filtros);
            _table.Add("suite", _suite);
            _table.Add("security", _security);
            _table.Add("password", _password);


        }
    }
    #endregion

}
