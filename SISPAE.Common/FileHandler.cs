/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>


using System;
using System.IO;
using System.Text;

namespace SISPAE.Common
{
    /// <summary>
    /// Purpose: Cross-cutting helper component for for creating and handling files and folders.
    /// </summary>
    public static class FileHandler
    {
        public static void WriteFile(string folderPath, string fileName, string fileText)
        {
            WriteFile(folderPath, fileName, fileText, false);
        }

        public static void WriteFile(string folderPath, string fileName, string fileText, bool bOverwrite)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                //use current path
                throw new ArgumentNullException("strFolderPath" + " The FolderPath cannot be null or empty. ");
            }
            if (string.IsNullOrEmpty(fileName))
            {
                //use current path
                throw new ArgumentNullException("strFileName" + " The FileName cannot be null or empty. ");
            }
            if (string.IsNullOrEmpty(fileText))
            {
                //use current path
                throw new ArgumentNullException("strFileText" + " The FileText cannot be null or empty. ");
            }

            // Check Folder, if doesn't exist then create it
            CreateFolder(folderPath);

            //make sure filename not like @"..\System\MyFile.txt" i.e. get pure file name
            fileName = Path.GetFileName(fileName);

            // instead of using Path.DirectorySeparatorChar
            string filePathAndName = Path.Combine(folderPath, fileName);

            if (File.Exists(filePathAndName))
            {
                if (bOverwrite)
                {
                    File.Delete(filePathAndName);
                }
                else
                {
                    return;
                }
            }

            try
            {
                using (var fs = new FileStream(filePathAndName, FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.Write(fileText);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            catch (Exception)
            {

                return  ;
            }
        }

        public static bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }


        public static void WriteFile(string folderPath, string fileName, byte[] fileByte, bool bOverwrite)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                //use current path
                throw new ArgumentNullException("strFolderPath" + " The FolderPath cannot be null or empty. ");
            }
            if (string.IsNullOrEmpty(fileName))
            {
                //use current path
                throw new ArgumentNullException("strFileName" + " The FileName cannot be null or empty. ");
            }
            if (fileByte.Length <= 0)
            {
                //use current path
                throw new ArgumentNullException("strFileByte" + " The FileText cannot be null or empty. ");
            }

            // Check Folder, if doesn't exist then create it
            CreateFolder(folderPath);

            //make sure filename not like @"..\System\MyFile.txt" i.e. get pure file name
            fileName = Path.GetFileName(fileName);

            // instead of using Path.DirectorySeparatorChar
            string filePathAndName = Path.Combine(folderPath, fileName);

            if (File.Exists(filePathAndName))
            {
                if (bOverwrite)
                {
                    File.Delete(filePathAndName);

                    using (System.IO.FileStream s = new FileStream(filePathAndName, FileMode.Create))
                    {
                        System.IO.BinaryWriter writer = new BinaryWriter(s);
                        writer.Write(fileByte, 0, fileByte.Length);
                        writer.Close();
                    }
                }
                else
                {

                    var counter = 1;
                    string e = Path.GetExtension(filePathAndName);
                    filePathAndName = filePathAndName.Replace($"{e}", $"({counter}){e}");
                    while (File.Exists(filePathAndName))
                    {
                        filePathAndName = filePathAndName.Replace($"({counter}){e}", $"({ counter + 1}){e}");
                        counter++;
                    }

                    using (System.IO.FileStream s = new FileStream(filePathAndName, FileMode.Create))
                    {
                        System.IO.BinaryWriter writer = new BinaryWriter(s);
                        writer.Write(fileByte, 0, fileByte.Length);
                        writer.Close();
                    }
                }
            }
            else
            {

                using (System.IO.FileStream s = new FileStream(filePathAndName, FileMode.Create))
                {
                    System.IO.BinaryWriter writer = new BinaryWriter(s);
                    writer.Write(fileByte, 0, fileByte.Length);
                    writer.Close();
                }

                //using (var fs = new FileStream(filePathAndName, FileMode.Create))
                //{
                //    using (var sw = new StreamWriter(fs, Encoding.UTF8))
                //    {
                //        sw.Write(fileByte);
                //        sw.Flush();
                //        sw.Close();
                //    }
                //}
            }

        }



        public static string CreateFolder(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                //use current path
                throw new ArgumentNullException("strFolderPath" + " The FolderPath cannot be null or empty. ");
            }

            //If directory exists, the delete it with all of its sub-folders
            if (!Directory.Exists(folderPath))
            {
                //Directory.Delete(strFolderPath, true);
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        public static string CreateFolder(string parentFolderPath, string folderName)
        {
            if (string.IsNullOrEmpty(parentFolderPath))
            {
                //use current path
                throw new ArgumentNullException("parentFolderPath" + " The Parent Folder Path cannot be null or empty. ");
            }
            if (string.IsNullOrEmpty(folderName))
            {
                //use current path
                throw new ArgumentNullException("folderName" + " The Folder Name cannot be null or empty. ");
            }

            folderName = Path.GetDirectoryName(folderName);

            if (folderName != null)
            {
                string strFolderPath = Path.Combine(parentFolderPath, folderName);
                if (!Directory.Exists(strFolderPath))
                {
                    Directory.CreateDirectory(strFolderPath);
                }

                return strFolderPath;
            }

            return string.Empty;
        }
    }
}
