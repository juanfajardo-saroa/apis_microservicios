/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>



using System;
using System.Configuration;
using System.Net;
using System.Xml.XPath;


namespace SISPAE.Common
{
    public static class Generator
    {
        public static string Short(string url, ServiceToUse service)
        {
            string result = "";
            WebClient WC = new WebClient();
            switch (service)
            {
                case ServiceToUse.IsGd:
                    try
                    {
                        result = WC.DownloadString("http://is.gd/api.php?longurl=" + url);
                    }
                    catch (WebException wex)
                    {
                        throw new Exception("There is a problem connecting service", wex);
                    }
                    break;
                case ServiceToUse.ToLy:
                    try
                    {
                        result = WC.DownloadString("http://to.ly/api.php?longurl=" + url);
                    }
                    catch (WebException wex)
                    {
                        throw new Exception("There is a problem connecting service", wex);
                    }
                    break;
                case ServiceToUse.BitLy:
                    {
                        if (ConfigurationManager.AppSettings["APILogin"] == null && ConfigurationManager.AppSettings["APIKey"] == null)
                        {
                            throw new ConfigurationErrorsException("Values for API Login and Key are not registered in Web.config");
                        }
                        string APILogin = ConfigurationManager.AppSettings["APILogin"].ToString();
                        string APIKey = ConfigurationManager.AppSettings["APIKey"].ToString();
                        try
                        {
                            string path = string.Concat(new string[]
                            {
                        "http://api.bit.ly/shorten?version=2.0.1&login=",
                        APILogin,
                        "&apiKey=",
                        APIKey,
                        "&format=xml&longUrl=",
                        url
                            });
                            XPathDocument doc = new XPathDocument(path);
                            XPathNavigator nav = doc.CreateNavigator();
                            XPathNodeIterator iterator = nav.Select("/bitly/results/nodeKeyVal/shortUrl");
                            while (iterator.MoveNext())
                            {
                                result = iterator.Current.Value;
                            }
                        }
                        catch (WebException wex)
                        {
                            throw new Exception("There is a problem connecting service", wex);
                        }
                        break;
                    }
                case ServiceToUse.JMp:
                    {
                        if (ConfigurationManager.AppSettings["APILogin"] == null && ConfigurationManager.AppSettings["APIKey"] == null)
                        {
                            throw new ConfigurationErrorsException("Values for API Login and Key are not registered in Web.config");
                        }
                        string APILogin = ConfigurationManager.AppSettings["APILogin"].ToString();
                        string APIKey = ConfigurationManager.AppSettings["APIKey"].ToString();
                        try
                        {
                            string path = string.Concat(new string[]
                            {
                        "http://api.j.mp/shorten?version=2.0.1&login=",
                        APILogin,
                        "&apiKey=",
                        APIKey,
                        "&format=xml&longUrl=",
                        url
                            });
                            XPathDocument doc = new XPathDocument(path);
                            XPathNavigator nav = doc.CreateNavigator();
                            XPathNodeIterator iterator = nav.Select("/bitly/results/nodeKeyVal/shortUrl");
                            while (iterator.MoveNext())
                            {
                                result = iterator.Current.Value;
                            }
                        }
                        catch (WebException wex)
                        {
                            throw new Exception("There is a problem connecting service", wex);
                        }
                        break;
                    }
                case ServiceToUse.TinyURL:
                    try
                    {
                        result = WC.DownloadString("http://tinyurl.com/api-create.php?url=" + url);
                    }
                    catch (WebException wex)
                    {
                        throw new Exception("There is a problem connecting service", wex);
                    }
                    break;
            }
            WC.Dispose();
            return result;
        }
    }
}
