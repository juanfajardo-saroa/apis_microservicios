/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>



using System;
using System.IO;

namespace SISPAE.Common
{
    public static class FTPUtilities
    {
        public struct FTPConfiguration
        {
            public Uri Address
            {
                get;
                set;
            }

            public string Username
            {
                get;
                set;
            }

            public string Password
            {
                get;
                set;
            }

            public string Proxy
            {
                get;
                set;
            }

            public bool Passive
            {
                get;
                set;
            }

            public int Port
            {
                get;
                set;
            }

            public bool KeepAlive
            {
                get;
                set;
            }
        }

        public static bool UploadFile(FTPUtilities.FTPConfiguration ftpConfig, Stream stream, string relativePath, string filename)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            if (filename.StartsWith("/"))
            {
                filename = filename.Substring(1, filename.Length - 1);
            }
            return FTP.UploadFile(stream, new Uri(ftpConfig.Address, relativePath + filename), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }

        public static bool DeleteFile(FTPUtilities.FTPConfiguration ftpConfig, string relativePath, string filename)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            if (filename.StartsWith("/"))
            {
                filename = filename.Substring(1, filename.Length - 1);
            }
            return FTP.DeleteFile(new Uri(ftpConfig.Address, relativePath + filename), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }

        public static bool ExistFile(FTPUtilities.FTPConfiguration ftpConfig, string relativePath, string filename)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            if (filename.StartsWith("/"))
            {
                filename = filename.Substring(1, filename.Length - 1);
            }
            return FTP.FileExist(new Uri(ftpConfig.Address, relativePath + filename), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }

        public static bool CreateDirectory(FTPUtilities.FTPConfiguration ftpConfig, string relativePath)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            return FTP.CreateDirectory(new Uri(ftpConfig.Address, relativePath), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }

        public static bool DeleteDirectory(FTPUtilities.FTPConfiguration ftpConfig, string relativePath)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            return FTP.DeleteDirectory(new Uri(ftpConfig.Address, relativePath), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }

        public static bool EmptyDirectory(FTPUtilities.FTPConfiguration ftpConfig, string relativePath)
        {
            if (relativePath.StartsWith("/"))
            {
                relativePath = relativePath.Substring(1, relativePath.Length - 1);
            }
            if (!relativePath.EndsWith("/"))
            {
                relativePath += "/";
            }
            return FTP.DeleteFilesInDirectory(new Uri(ftpConfig.Address, relativePath), ftpConfig.Username, ftpConfig.Password, ftpConfig.Proxy, ftpConfig.Passive, ftpConfig.Port, ftpConfig.KeepAlive);
        }
    }
}
