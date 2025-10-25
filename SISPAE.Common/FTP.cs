/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>



using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SISPAE.Common
{
    public static class FTP
    {
        public enum UpdateFileError
        {
            UnknowError,
            Success,
            NotNeeded,
            ErrorDuringDownload,
            BackupFailded,
            Failed,
            OldFileNotFound,
            NewFileNotFound,
            Needed
        }

        public static bool UploadFile(string sourceFile, Uri destinationFile, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(destinationFile)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "STOR";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FileStream streamObj = File.OpenRead(sourceFile))
                {
                    byte[] buffer = new byte[streamObj.Length];
                    streamObj.Read(buffer, 0, buffer.Length);
                    using (Stream respStream = reqObj.GetRequestStream())
                    {
                        respStream.Write(buffer, 0, buffer.Length);
                        result = true;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool UploadFile(byte[] sourceBytes, Uri destinationFile, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(destinationFile)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "STOR";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (Stream respStream = reqObj.GetRequestStream())
                {
                    respStream.Write(sourceBytes, 0, sourceBytes.Length);
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool UploadFile(Stream sourceStream, Uri destinationFile, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(destinationFile)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "STOR";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                byte[] arrayFile = new byte[sourceStream.Length];
                try
                {
                    sourceStream.Read(arrayFile, 0, Convert.ToInt32(sourceStream.Length));
                    using (Stream respStream = reqObj.GetRequestStream())
                    {
                        respStream.Write(arrayFile, 0, arrayFile.Length);
                        result = true;
                    }
                }
                finally
                {
                    if (sourceStream != null)
                    {
                        ((IDisposable)sourceStream).Dispose();
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static MemoryStream DownloadFileStream(Uri sourceFile, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            MemoryStream result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(sourceFile)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "RETR";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                FtpWebResponse response = reqObj.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();
                MemoryStream memStream = new MemoryStream();
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    memStream.Write(buffer, 0, bytesRead);
                }
                reader.Close();
                reader.Dispose();
                memStream.Close();
                response.Close();
                result = memStream;
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static byte[] DownloadFileBytes(Uri sourceFile, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            byte[] downloadedData = null;
            byte[] result;
            try
            {
                result = FTP.DownloadFileStream(sourceFile, username, password, proxyAddress, passive, port, keepAlive).ToArray();
            }
            catch
            {
                result = downloadedData;
            }
            return result;
        }

        public static bool DeleteFile(Uri file, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(file)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "DELE";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        using (Stream responseStream = ftpResponse.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                result = true;
                                return result;
                            }
                            result = false;
                            return result;
                        }
                    }
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool MoveFile(Uri fileToRename, string newDirectoryLocation, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(fileToRename)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "RENAME";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (!newDirectoryLocation.EndsWith("/"))
                {
                    newDirectoryLocation += "/";
                }
                string[] segment = fileToRename.Segments;
                string page = segment[segment.Length - 1];
                reqObj.RenameTo = newDirectoryLocation + page;
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool MoveFile(Uri fileToRename, string newDirectoryLocation, string newFilename, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(fileToRename)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "RENAME";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (!newDirectoryLocation.EndsWith("/"))
                {
                    newDirectoryLocation += "/";
                }
                reqObj.RenameTo = newDirectoryLocation + newFilename;
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool RenameFile(Uri fileToRename, string newFilename, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                if (newFilename.Contains("/") || newFilename.Contains("//") || newFilename.Contains("\\") || newFilename.Contains("\\"))
                {
                    result = false;
                }
                else
                {
                    FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(fileToRename)
                    {
                        Port = port
                    }.Uri);
                    reqObj.Credentials = new NetworkCredential(username, password);
                    reqObj.Method = "RENAME";
                    reqObj.RenameTo = newFilename;
                    reqObj.UsePassive = passive;
                    reqObj.KeepAlive = keepAlive;
                    using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                    {
                        if (ftpResponse != null)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool RenameDirectory(Uri directoryToRename, string newDirectoryName, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                if (newDirectoryName.Contains("/") || newDirectoryName.Contains("//") || newDirectoryName.Contains("\\") || newDirectoryName.Contains("\\"))
                {
                    result = false;
                }
                else
                {
                    FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(directoryToRename)
                    {
                        Port = port
                    }.Uri);
                    reqObj.Credentials = new NetworkCredential(username, password);
                    reqObj.Method = "RENAME";
                    reqObj.RenameTo = newDirectoryName;
                    reqObj.UsePassive = passive;
                    reqObj.KeepAlive = keepAlive;
                    using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                    {
                        if (ftpResponse != null)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static DateTime? GetFileDate(Uri filename, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            DateTime? result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(filename)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "MDTM";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = new DateTime?(ftpResponse.LastModified);
                    }
                    else
                    {
                        result = null;
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static long GetFileSize(Uri filename, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            long result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(filename)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "SIZE";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = ftpResponse.ContentLength;
                    }
                    else
                    {
                        result = 0L;
                    }
                }
            }
            catch
            {
                result = 0L;
            }
            return result;
        }

        public static bool FileExist(Uri filename, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(filename)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "MDTM";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool FileExist(Uri filename)
        {
            bool result;
            try
            {
                Uri newUri = new Uri(filename.AbsoluteUri.Replace("ftp:/", "http:/"));
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(newUri);
                HttpWebResponse arg_32_0 = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpWebRequest != null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool CreateDirectory(Uri directory, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(directory)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "MKD";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using (FtpWebResponse ftpResponse = (FtpWebResponse)reqObj.GetResponse())
                {
                    if (ftpResponse != null)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool DeleteDirectory(Uri directory, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                List<string> filesDetails = FTP.GetFilesList(directory, username, password, proxyAddress, passive, port, keepAlive, true);
                List<string> files = FTP.GetFilesList(directory, username, password, proxyAddress, passive, port, keepAlive, false);
                for (int i = 0; i < files.Count; i++)
                {
                    string[] splitted = files[i].Split(new char[]
                    {
                        '/'
                    });
                    files[i] = splitted[splitted.Length - 1];
                }
                if (files.Count >= 0)
                {
                    for (int j = 0; j < files.Count; j++)
                    {
                        bool isDirectory = false;
                        if (filesDetails[j].Substring(0, 1).ToLower() == "d")
                        {
                            isDirectory = true;
                        }
                        if (isDirectory)
                        {
                            FTP.DeleteDirectory(new Uri(directory + "/" + files[j]), username, password, proxyAddress, passive, port, keepAlive);
                        }
                        else
                        {
                            FTP.DeleteFile(new Uri(directory + "/" + files[j]), username, password, proxyAddress, passive, port, keepAlive);
                        }
                    }
                }
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(directory)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                reqObj.Method = "RMD";
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                using ((FtpWebResponse)reqObj.GetResponse())
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool DeleteFilesInDirectory(Uri directory, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            bool result;
            try
            {
                List<string> filesDetails = FTP.GetFilesList(directory, username, password, proxyAddress, passive, port, keepAlive, true);
                List<string> filesMisc = FTP.GetFilesList(directory, username, password, proxyAddress, passive, port, keepAlive, false);
                List<string> files = new List<string>();
                for (int i = 0; i < filesMisc.Count; i++)
                {
                    string[] splitted = filesMisc[i].Split(new char[]
                    {
                        '/'
                    });
                    filesMisc[i] = splitted[splitted.Length - 1];
                    if (filesDetails[i].Substring(0, 1).ToLower() != "d")
                    {
                        files.Add(filesMisc[i]);
                    }
                }
                int count = 0;
                if (files.Count >= 0)
                {
                    for (int j = 0; j < files.Count; j++)
                    {
                        if (FTP.DeleteFile(new Uri(directory + "/" + files[j]), username, password, proxyAddress, passive, port, keepAlive))
                        {
                            count++;
                        }
                    }
                }
                if (count == files.Count)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static List<string> GetFilesList(Uri address, string username, string password, string proxyAddress, bool passive, int port, bool keepAlive, bool details)
        {
            List<string> files = new List<string>();
            List<string> result;
            try
            {
                FtpWebRequest reqObj = (FtpWebRequest)WebRequest.Create(new UriBuilder(address)
                {
                    Port = port
                }.Uri);
                reqObj.Credentials = new NetworkCredential(username, password);
                if (details)
                {
                    reqObj.Method = "LIST";
                }
                else
                {
                    reqObj.Method = "NLST";
                }
                if (proxyAddress != string.Empty)
                {
                    reqObj.Proxy = new WebProxy(proxyAddress);
                }
                reqObj.UsePassive = passive;
                reqObj.KeepAlive = keepAlive;
                FtpWebResponse response = reqObj.GetResponse() as FtpWebResponse;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                while (!reader.EndOfStream)
                {
                    files.Add(reader.ReadLine());
                }
                reader.Close();
                responseStream.Close();
                response.Close();
                result = files;
            }
            catch
            {
                result = files;
            }
            return result;
        }

        public static FTP.UpdateFileError UpdateFile(Uri fileToUpdate, Uri updatedFile, string usernameToUpdate, string passwordToUpdate, string usernameUpdated, string passwordUpdated, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            FTP.UpdateFileError result;
            try
            {
                DateTime? oldFileDate = FTP.GetFileDate(fileToUpdate, usernameToUpdate, passwordToUpdate, proxyAddress, passive, port, keepAlive);
                DateTime? newFileDate = FTP.GetFileDate(updatedFile, usernameUpdated, passwordUpdated, proxyAddress, passive, port, keepAlive);
                if (oldFileDate.HasValue)
                {
                    if (newFileDate.HasValue)
                    {
                        if (oldFileDate < newFileDate)
                        {
                            byte[] newFile = FTP.DownloadFileBytes(updatedFile, usernameUpdated, passwordUpdated, proxyAddress, passive, port, keepAlive);
                            if (newFile == null)
                            {
                                result = FTP.UpdateFileError.ErrorDuringDownload;
                            }
                            else
                            {
                                string filename = Path.GetFileNameWithoutExtension(fileToUpdate.AbsoluteUri);
                                string ext = Path.GetExtension(fileToUpdate.AbsoluteUri);
                                string filenameBAK = filename + "_BAK" + DateTime.Now.Date.ToShortDateString().Replace("/", "");
                                string newFilename = filenameBAK + ext;
                                if (!FTP.RenameFile(fileToUpdate, newFilename, usernameToUpdate, passwordToUpdate, proxyAddress, passive, port, keepAlive))
                                {
                                    result = FTP.UpdateFileError.BackupFailded;
                                }
                                else if (FTP.UploadFile(newFile, fileToUpdate, usernameToUpdate, passwordToUpdate, proxyAddress, passive, port, keepAlive))
                                {
                                    result = FTP.UpdateFileError.Success;
                                }
                                else
                                {
                                    string backupFilename = fileToUpdate.AbsoluteUri.Replace(Path.GetFileName(fileToUpdate.AbsoluteUri), newFilename);
                                    string oldFilename = Path.GetFileName(fileToUpdate.AbsoluteUri);
                                    FTP.RenameFile(new Uri(backupFilename), oldFilename, usernameToUpdate, passwordToUpdate, proxyAddress, passive, port, keepAlive);
                                    result = FTP.UpdateFileError.Failed;
                                }
                            }
                        }
                        else
                        {
                            result = FTP.UpdateFileError.NotNeeded;
                        }
                    }
                    else
                    {
                        result = FTP.UpdateFileError.NewFileNotFound;
                    }
                }
                else
                {
                    result = FTP.UpdateFileError.OldFileNotFound;
                }
            }
            catch
            {
                result = FTP.UpdateFileError.UnknowError;
            }
            return result;
        }

        public static FTP.UpdateFileError FileToBeUpdate(Uri fileToUpdate, Uri updatedFile, string usernameToUpdate, string passwordToUpdate, string usernameUpdated, string passwordUpdated, string proxyAddress, bool passive, int port, bool keepAlive)
        {
            FTP.UpdateFileError result;
            try
            {
                DateTime? oldFileDate = FTP.GetFileDate(fileToUpdate, usernameToUpdate, passwordToUpdate, proxyAddress, passive, port, keepAlive);
                DateTime? newFileDate = FTP.GetFileDate(updatedFile, usernameUpdated, passwordUpdated, proxyAddress, passive, port, keepAlive);
                if (oldFileDate.HasValue)
                {
                    if (newFileDate.HasValue)
                    {
                        if (oldFileDate < newFileDate)
                        {
                            result = FTP.UpdateFileError.Needed;
                        }
                        else
                        {
                            result = FTP.UpdateFileError.NotNeeded;
                        }
                    }
                    else
                    {
                        result = FTP.UpdateFileError.NewFileNotFound;
                    }
                }
                else
                {
                    result = FTP.UpdateFileError.OldFileNotFound;
                }
            }
            catch
            {
                result = FTP.UpdateFileError.UnknowError;
            }
            return result;
        }
    }
}
