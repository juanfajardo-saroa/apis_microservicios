using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SISPAE.Common
{
    /// <summary>
    /// Purpose: Cross-cutting helper component for for creating and handling Logging activities.
    /// </summary>
    public class LoggingHandler : IDisposable
    {
        #region Class Methods


        public static IConfigurationRoot Configuration;

        private void InitLoggingHandlerClass()
        {
            try
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");
                Configuration = builder.Build();

                using (var configHandler = new ConfigurationHandler())
                {
                    //EnableLogging = bool.Parse(configHandler.GetAppSettingsValueByKey("EnableLogging").ToLower());
                    //EnableLogging = bool.Parse(Configuration["AppIdentitySettings:EnableLogging"].ToLower());
                    EnableLogging = bool.Parse(Configuration["AppIdentitySettings:EnableLogging"].ToString());

                    //LoggingPath = configHandler.GetAppSettingsValueByKey("LoggingPath");
                    //LoggingPath = Configuration["AppIdentitySettings:LoggingPath"].ToString();
                    LoggingPath = Configuration["AppIdentitySettings:LoggingPath"].ToString();

                }
            }
            catch (Exception ex)
            {
                //bubble error.
                throw new Exception("LoggingHandler::InitLoggingHandlerClass:Error occured.", ex);
            }
        }

        public void LogEntry(string loggedText, bool bIsError = false)
        {
            if (EnableLogging)
            {
                if (bIsError)
                {
                    FileHandler.WriteFile(LoggingPath, DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss.") + "Error.txt", loggedText);
                }
                else
                {
                    FileHandler.WriteFile(LoggingPath, DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss.") + "Log.txt", loggedText);
                }
            }
        }

        public LoggingHandler()
        {
            InitLoggingHandlerClass();
        }

        /// <summary>
        /// Purpose: Implements the IDispose interface.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Class Properties

        public bool EnableLogging { get; set; }
        public string LoggingPath { get; set; }

        #endregion
    }
}
