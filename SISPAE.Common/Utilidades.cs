using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SISPAE.Common
{
    /// <summary>
    /// Purpose: Helper Data Handler Class for data parameters and types conversion.
    /// </summary>
    public static class Utilidades
    {



        public static string IdProcessor;

        public static string MACAddressID;

        public static string MotherBoardId;

        public static string BiosSN;

        public static string OS;

        private static string Key1;

        private static string Key2;

        private static string Key3;

        private static string Key4;

        private static string Key5;

        [DebuggerNonUserCode]
        public static string utils()
        {
            return "";
        }

        public static string GetProcessorId()
        {
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_Processor");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = "";
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    result = Conversions.ToString(managementObject["ProcessorID"]);
                }
            }
            finally
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();

                if (enumerator != null)
                {
                    ((IDisposable)enumerator).Dispose();
                }
            }
            return result;
        }

        public static string GetMACAddress()
        {
            ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    if (Operators.CompareString(text, string.Empty, false) == 0 && Conversions.ToBoolean(managementObject["IPEnabled"]))
                    {
                        text = managementObject["MacAddress"].ToString();
                    }
                    managementObject.Dispose();
                }
            }
            finally
            {
                // ManagementObjectCollection.ManagementObjectEnumerator enumerator;
                //ManagementObject managementObject = (ManagementObject)enumerator.Current;
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                if (enumerator != null)
                {
                    ((IDisposable)enumerator).Dispose();
                }
            }
            text = text.Replace(":", "");
            return text;
        }

        public static string GetMotherBoardID()
        {
            ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    if (Operators.CompareString(text, string.Empty, false) == 0)
                    {
                        text = managementObject["SerialNumber"].ToString();
                    }
                    managementObject.Dispose();
                }
            }
            finally
            {
                // ManagementObjectCollection.ManagementObjectEnumerator enumerator;
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                if (enumerator != null)
                {
                    ((IDisposable)enumerator).Dispose();
                }
            }
            text = text.Replace(".", "");
            return text;
        }

        public static string GetBiosSerial()
        {
            ManagementClass managementClass = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    if (Operators.CompareString(text, string.Empty, false) == 0)
                    {
                        text = managementObject["SerialNumber"].ToString();
                    }
                    managementObject.Dispose();
                }
            }
            finally
            {
                // ManagementObjectCollection.ManagementObjectEnumerator enumerator;
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                if (enumerator != null)
                {
                    ((IDisposable)enumerator).Dispose();
                }
            }
            text = text.Replace(".", "");
            return text;
        }

        public static string GetSO()
        {
            ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = managementClass.GetInstances();
            string text = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    if (Operators.CompareString(text, string.Empty, false) == 0)
                    {
                        text = managementObject["Caption"].ToString();
                    }
                    managementObject.Dispose();
                }
            }
            finally
            {
                //ManagementObjectCollection.ManagementObjectEnumerator enumerator;
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                if (enumerator != null)
                {
                    ((IDisposable)enumerator).Dispose();
                }
            }
            text = text.Replace(".", "");
            return text;
        }

        public static string Generate(int Type)
        {
            string text;
            if (Type == 1)
            {
                text = IdProcessor + MACAddressID + MotherBoardId;
            }
            else
            {
                BiosSN = GetBiosSerial();
                text = IdProcessor + MACAddressID + BiosSN;
            }
            KeyContainerPermission keyContainerPermission = new KeyContainerPermission(PermissionState.Unrestricted);
            RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(4096, new CspParameters
            {
                //KeyContainerName = text,
                Flags = CspProviderFlags.UseMachineKeyStore,
                KeyNumber = 2,
                ProviderType = 1,
                ProviderName = "Microsoft Base Cryptographic Provider v1.0",
                KeyContainerName = "LicenseGenerator"
            });
            RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(true);
            RSAParameters rSAParameters2 = rSACryptoServiceProvider.ExportParameters(false);
            text = rSACryptoServiceProvider.ToXmlString(true);
            string[] array = text.Split(new char[]
            {
                '>'
            });
            array = array[2].Split(new char[]
            {
                '<'
            });
            text = array[0].Replace("=", "");
            double num = (double)Strings.AscW(text);
            double num2 = Math.Log(num);
            num = Math.Sqrt(num);
            num = num * num2 / 3.0 + 2.0;
            num = Math.Round(num);
            checked
            {
                text = Mid(text, (int)Math.Round(num), 25);
                text = Conversions.ToString(clean(text));
                text = text.ToUpper();
                int num3 = 1;
                int num4 = 1;
                do
                {
                    string text2 = Mid(text, num3, 5);
                    switch (num4)
                    {
                        case 1:
                            Key1 = text2;
                            break;
                        case 2:
                            Key2 = text2;
                            break;
                        case 3:
                            Key3 = text2;
                            break;
                        case 4:
                            Key4 = text2;
                            break;
                        case 5:
                            Key5 = text2;
                            break;
                    }
                    num4++;
                    num3 += 5;
                }
                while (num3 != 26);
                return string.Concat(new string[]
                {
                    Key1,
                    " - ",
                    Key2,
                    " - ",
                    Key3,
                    " - ",
                    Key4,
                    " - ",
                    Key5
                });
            }
        }

        public static string Mid(string input, int index, char newChar)

        {

            if (input == null)

            {

                throw new ArgumentNullException("input");

            }

            char[] chars = input.ToCharArray();

            chars[index - 1] = newChar;

            return new string(chars);

        }


        public static string Mid(string s, int a, int b)

        {

            string temp = s.Substring(a - 1, b);

            return temp;

        }

        public static object clean(string dato)
        {
            if (dato.Contains("+"))
            {
                dato = dato.Replace("+", "E");
            }
            if (dato.Contains("@"))
            {
                dato = dato.Replace("@", "F");
            }
            if (dato.Contains(" "))
            {
                dato = dato.Replace(" ", "W");
            }
            if (dato.Contains("\""))
            {
                dato = dato.Replace("\"", "U");
            }
            if (dato.Contains("'"))
            {
                dato = dato.Replace("'", "B");
            }
            if (dato.Contains(","))
            {
                dato = dato.Replace(",", "X");
            }
            if (dato.Contains("?"))
            {
                dato = dato.Replace("?", "A");
            }
            if (dato.Contains("+"))
            {
                dato = dato.Replace("o", "T");
            }
            if (dato.Contains(" "))
            {
                dato = dato.Replace("-", "D");
            }
            if (dato.Contains("="))
            {
                dato = dato.Replace("=", "P");
            }
            if (dato.Contains("'"))
            {
                dato = dato.Replace("o", "C");
            }
            if (dato.Contains(","))
            {
                dato = dato.Replace("o", "V");
            }
            if (dato.Contains("?"))
            {
                dato = dato.Replace("/", "F");
            }
            if (dato.Contains("\\"))
            {
                dato = dato.Replace("/", "G");
            }
            if (dato.Contains("/"))
            {
                dato = dato.Replace("/", "E");
            }
            return dato;
        }

        public static object SendEmail(string ToAddress, string FromAddress, string MessageSubject, string MessageBody, string SmtpHost, string password, string smtpPort = "25")
        {
            string str = "<html><head>";
            str += "<style>";
            str += "body {background-color:#FFF; color:#000; font-family:arial,verdana,sans-serif; font-size:12px;}";
            str += "</style></head><body>";
            string str2 = "</body></html>";
            MessageBody = str + MessageBody + str2;
            string result = "";
            MailMessage mailMessage = new MailMessage(FromAddress, ToAddress);
            SmtpClient smtpClient = new SmtpClient();
            mailMessage.Subject = MessageSubject;
            mailMessage.Body = MessageBody;
            mailMessage.IsBodyHtml = true;
            try
            {
                if (FromAddress.Contains("gmail"))
                {
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                }
                else if (FromAddress.Contains("hotmail"))
                {
                    smtpClient.Host = "smtp.live.com";
                    smtpClient.Port = 25;
                }
                else
                {
                    smtpClient.Host = SmtpHost;
                    smtpClient.Port = Conversions.ToInteger(smtpPort);
                }
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(FromAddress, password);
                smtpClient.Send(mailMessage);
                result = "Email has been dispatched";
            }
            catch (Exception expr_F7)
            {
                ProjectData.SetProjectError(expr_F7);
                Exception ex = expr_F7;
                result = "We're sorry, there has been an error: " + ex.Message;
                ProjectData.ClearProjectError();
            }
            return result;
        }


        public static string GetRandomPassword(int numOfCharsNeeded)
        {
            return Guid.NewGuid().ToString("n").Substring(0, numOfCharsNeeded);
        }

        public static string GetCleanUrl(string url)
        {
            string urlAlias = url.Replace(" | ", "-");
            urlAlias = urlAlias.Replace("/", "-");
            urlAlias = urlAlias.Replace("(", "-");
            urlAlias = urlAlias.Replace(")", "-");
            urlAlias = urlAlias.Replace("$", "-");
            urlAlias = urlAlias.Replace(":", "-");
            urlAlias = urlAlias.Replace("!", "-");
            urlAlias = urlAlias.Replace("+", "-");
            urlAlias = urlAlias.Replace("&", "-");
            urlAlias = urlAlias.Replace("*", "-");
            urlAlias = urlAlias.Replace("%", "-");
            urlAlias = urlAlias.Replace("=", "-");
            urlAlias = urlAlias.Replace("#", "-");
            urlAlias = urlAlias.Replace("'", "-");
            urlAlias = urlAlias.Replace("''", "-");
            urlAlias = urlAlias.Replace(",", "-");
            urlAlias = urlAlias.Replace("`", "-");
            urlAlias = urlAlias.Replace("^", "-");
            urlAlias = urlAlias.Replace("~", "-");
            urlAlias = urlAlias.Replace("?", "-");
            urlAlias = urlAlias.Replace(" ", "-");
            urlAlias = urlAlias.Replace("----", "-");
            urlAlias = urlAlias.Replace("---", "-");
            return urlAlias.Replace("--", "-");
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z");
        }

        public static string EncryptPasswordMD5(string password)
        {
            string rtn = string.Empty;
            if (password != null)
            {
                rtn = MD5Hash(password);
            }
            return rtn;
        }

        public static string MD5Hash(string password)
        {
            string rtn = string.Empty;
            if (password != null)
            {
                byte[] hashed = new MD5CryptoServiceProvider().ComputeHash(new UTF7Encoding().GetBytes(password));
                byte[] array = hashed;
                for (int i = 0; i < array.Length; i++)
                {
                    byte b = array[i];
                    rtn += string.Format("{0:x2}", b);
                }
            }
            return rtn;
        }

        public static string ConvertDateTimeToyyyyMMdd(DateTime date)
        {
            string convertedDate = string.Empty;
            return date.ToString("yyyy-MM-dd");
        }

        public static bool IsNumeric(string str)
        {
            double num = 0.0;
            return double.TryParse(str, out num);
        }

        public static int CalcFactorial(int i)
        {
            return (i <= 1) ? 1 : (i * Utilidades.CalcFactorial(i - 1));
        }

        public static int NumberOfDigits(string theString)
        {
            int count = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                if (char.IsDigit(theString[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static string Encrypt(string plainText)
        {
            string key = "G3N3R4App#";
            byte[] EncryptKey = { };
            byte[] IV = { 55, 34, 87, 64, 87, 195, 54, 21 };
            EncryptKey = System.Text.Encoding.UTF8.GetBytes(key.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByte = Encoding.UTF8.GetBytes(plainText);
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, des.CreateEncryptor(EncryptKey, IV), CryptoStreamMode.Write);
            cStream.Write(inputByte, 0, inputByte.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }


        public static string Decrypt(string encryptedText)
        {

            string key = "G3N3R4App#";
            byte[] DecryptKey = { };
            byte[] IV = { 55, 34, 87, 64, 87, 195, 54, 21 };
            //byte[] inputByte = new byte[encryptedText.Length];

            DecryptKey = System.Text.Encoding.UTF8.GetBytes(key.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByte = Convert.FromBase64String(encryptedText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(DecryptKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByte, 0, inputByte.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

        public static string DecryptString(string encryptedText)
        {
            string keyString = "G3N3R4App#";
            var fullCipher = Convert.FromBase64String(encryptedText);
            var iv = new byte[16];
            var cipher = new byte[16];
            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(keyString);
            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                    return result;
                }
            }
        }


        public static string EncryptString(string plainText)
        {
            string keyString = "G3N3R4App#";
            var key = Encoding.UTF8.GetBytes(keyString);
            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        var iv = aesAlg.IV;
                        var decryptedContent = msEncrypt.ToArray();
                        var result = new byte[iv.Length + decryptedContent.Length];
                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);
                        return Convert.ToBase64String(result);
                    }
                }
            }
        }


        public static string Encrypt2898(string plainText)
        {
            string keyString = "G3N3R4App#";
            byte[] clearBytes = Encoding.Unicode.GetBytes(plainText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(keyString, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    plainText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return plainText;
        }
        public static string Decrypt2898(string plainText)
        {
            string keyString = "G3N3R4App#";
            plainText = plainText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(plainText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(keyString, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    plainText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return plainText;
        }
        public static string EncryptMD5(string plainText, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(plainText);
            string keyString = "G3N3R4App#";

            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(keyString));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(keyString);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string DecryptMD5(string plainText, bool useHashing)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(plainText);
            string keyString = "G3N3R4App#";


            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(keyString));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(keyString);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }




        private static byte[] EncryptSHA(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {

            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }

                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        private static byte[] DecryptSHA(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {

            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }

                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }



        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }





        public static string GetFileName(string filenameWithExtention)
        {
            string filenameWithoutExtention = string.Empty;
            if (!string.IsNullOrEmpty(filenameWithExtention))
            {
                filenameWithoutExtention = Path.GetFileNameWithoutExtension(filenameWithExtention);
            }
            return filenameWithoutExtention;
        }

        public static string GetFileExtention(string filenameWithExtention)
        {
            string extention = string.Empty;
            if (!string.IsNullOrEmpty(filenameWithExtention))
            {
                extention = Path.GetExtension(filenameWithExtention);
            }
            return extention;
        }

        public static string ShorteURL(string url)
        {
            Uri address = new Uri("http://tinyurl.com/api-create.php?url=" + url);
            WebClient client = new WebClient();
            return client.DownloadString(address);
        }

        public static string FormatePrice(double value, string currType, string culture)
        {
            string curr = string.Empty;
            if (string.IsNullOrEmpty(currType))
            {
                currType = "C";
            }
            if (culture != null)
            {
                curr = value.ToString(currType, CultureInfo.CreateSpecificCulture(culture));
            }
            else
            {
                curr = value.ToString(currType, CultureInfo.CurrentCulture);
            }
            return curr;
        }




        public static void AppendScriptNode(StringBuilder source, string rawScript)
        {
            source.Replace("</head>", "<script>" + rawScript + "</script></head>");
        }





        private static MD5 md5 = new MD5CryptoServiceProvider();

        public static string ToMD5(this string text)
        {
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            var builder = new StringBuilder();

            foreach (var b in bytes)
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }

        public static string ToUrl(this string text, Encoding enc = null)
        {
            if (enc == null) enc = Encoding.UTF8;
            return HttpUtility.UrlEncode(text, enc);
        }

        public static void FindBetween(string text, string from, string to, out string result, out int index,
                                       int start = 0, bool careEscape = false, string escaper = "\\")
        {
        Again1:
            var i1 = text.IndexOf(from, start);
            if (careEscape &&
                i1 - escaper.Length >= 0 &&
                text.Substring(i1 - escaper.Length, escaper.Length) == escaper)
            {
                start = i1 + 1;
                goto Again1;
            }

            if (i1 == -1)
            {
                result = null;
                index = -1;
                return;
            }
            i1 += from.Length;
            var searcher = i1;
        Again2:

            var i2 = text.IndexOf(to, searcher);
            if (careEscape &&
                i2 - escaper.Length >= 0 &&
                text.Substring(i2 - escaper.Length, escaper.Length) == escaper)
            {
                searcher = i2 + 1;
                goto Again2;
            }

            if (i2 == -1)
            {
                result = null;
                index = -1;
                return;
            }
            result = text.Substring(i1, i2 - i1);
            if (careEscape)
            {
                result = result.Replace(escaper + from, from);
                result = result.Replace(escaper + to, to);
            }
            index = i1;
        }

        public static string GetBetween(this string input, string startTag, string endTag, bool careEscape = false,
                                        string escaper = "\\")
        {
            return FindBetweenFirst(input, startTag, endTag, careEscape, escaper);
        }

        public static string FindBetweenFirst(string text, string from, string to, bool careEscape = false,
                                              string escaper = "\\")
        {
            string result;
            int index;
            FindBetween(text, from, to, out result, out index, 0, careEscape, escaper);
            return result;
        }

        public static void FindBetweenExecute(string text, string from, string to, Action<string> action,
                                              bool careEscape = false, string escaper = "\\")
        {
            string s;
            var i = 0;
            while (true)
            {
                FindBetween(text, from, to, out s, out i, i, careEscape, escaper);
                if (i == -1) break;
                action(s);
            }
        }

        public static void GetBetweenExecute(this string input, string startTag, string endTag, Action<string> action,
                                             bool careEscape = false, string escaper = "\\")
        {
            FindBetweenExecute(input, startTag, endTag, action, careEscape, escaper);
        }

        public static int Factor(this int number)
        {
            var max = (int)Math.Sqrt(number); //round down
            for (var factor = 2; factor <= max && factor <= 5; ++factor)
                if (number % factor == 0)
                    return factor;

            return 1;
        }







        private static string GetDefinedMimeType(string extension)
        {
            if (extension == null)
                throw new ArgumentNullException("extension");

            if (extension.StartsWith("."))
                extension = extension.Substring(1);


            switch (extension.ToLower())
            {
                #region Big freaking list of mime types

                case "323":
                    return "text/h323";
                case "3g2":
                    return "video/3gpp2";
                case "3gp":
                    return "video/3gpp";
                case "3gp2":
                    return "video/3gpp2";
                case "3gpp":
                    return "video/3gpp";
                case "7z":
                    return "application/x-7z-compressed";
                case "aa":
                    return "audio/audible";
                case "aac":
                    return "audio/aac";
                case "aaf":
                    return "application/octet-stream";
                case "aax":
                    return "audio/vnd.audible.aax";
                case "ac3":
                    return "audio/ac3";
                case "aca":
                    return "application/octet-stream";
                case "accda":
                    return "application/msaccess.addin";
                case "accdb":
                    return "application/msaccess";
                case "accdc":
                    return "application/msaccess.cab";
                case "accde":
                    return "application/msaccess";
                case "accdr":
                    return "application/msaccess.runtime";
                case "accdt":
                    return "application/msaccess";
                case "accdw":
                    return "application/msaccess.webapplication";
                case "accft":
                    return "application/msaccess.ftemplate";
                case "acx":
                    return "application/internet-property-stream";
                case "addin":
                    return "text/xml";
                case "ade":
                    return "application/msaccess";
                case "adobebridge":
                    return "application/x-bridge-url";
                case "adp":
                    return "application/msaccess";
                case "adt":
                    return "audio/vnd.dlna.adts";
                case "adts":
                    return "audio/aac";
                case "afm":
                    return "application/octet-stream";
                case "ai":
                    return "application/postscript";
                case "aif":
                    return "audio/x-aiff";
                case "aifc":
                    return "audio/aiff";
                case "aiff":
                    return "audio/aiff";
                case "air":
                    return "application/vnd.adobe.air-application-installer-package+zip";
                case "amc":
                    return "application/x-mpeg";
                case "application":
                    return "application/x-ms-application";
                case "art":
                    return "image/x-jg";
                case "asa":
                    return "application/xml";
                case "asax":
                    return "application/xml";
                case "ascx":
                    return "application/xml";
                case "asd":
                    return "application/octet-stream";
                case "asf":
                    return "video/x-ms-asf";
                case "ashx":
                    return "application/xml";
                case "asi":
                    return "application/octet-stream";
                case "asm":
                    return "text/plain";
                case "asmx":
                    return "application/xml";
                case "aspx":
                    return "application/xml";
                case "asr":
                    return "video/x-ms-asf";
                case "asx":
                    return "video/x-ms-asf";
                case "atom":
                    return "application/atom+xml";
                case "au":
                    return "audio/basic";
                case "avi":
                    return "video/x-msvideo";
                case "axs":
                    return "application/olescript";
                case "bas":
                    return "text/plain";
                case "bcpio":
                    return "application/x-bcpio";
                case "bin":
                    return "application/octet-stream";
                case "bmp":
                    return "image/bmp";
                case "c":
                    return "text/plain";
                case "cab":
                    return "application/octet-stream";
                case "caf":
                    return "audio/x-caf";
                case "calx":
                    return "application/vnd.ms-office.calx";
                case "cat":
                    return "application/vnd.ms-pki.seccat";
                case "cc":
                    return "text/plain";
                case "cd":
                    return "text/plain";
                case "cdda":
                    return "audio/aiff";
                case "cdf":
                    return "application/x-cdf";
                case "cer":
                    return "application/x-x509-ca-cert";
                case "chm":
                    return "application/octet-stream";
                case "class":
                    return "application/x-java-applet";
                case "clp":
                    return "application/x-msclip";
                case "cmx":
                    return "image/x-cmx";
                case "cnf":
                    return "text/plain";
                case "cod":
                    return "image/cis-cod";
                case "config":
                    return "application/xml";
                case "contact":
                    return "text/x-ms-contact";
                case "coverage":
                    return "application/xml";
                case "cpio":
                    return "application/x-cpio";
                case "cpp":
                    return "text/plain";
                case "crd":
                    return "application/x-mscardfile";
                case "crl":
                    return "application/pkix-crl";
                case "crt":
                    return "application/x-x509-ca-cert";
                case "cs":
                    return "text/plain";
                case "csdproj":
                    return "text/plain";
                case "csh":
                    return "application/x-csh";
                case "csproj":
                    return "text/plain";
                case "css":
                    return "text/css";
                case "csv":
                    return "text/csv";
                case "cur":
                    return "application/octet-stream";
                case "cxx":
                    return "text/plain";
                case "dat":
                    return "application/octet-stream";
                case "datasource":
                    return "application/xml";
                case "dbproj":
                    return "text/plain";
                case "dcr":
                    return "application/x-director";
                case "def":
                    return "text/plain";
                case "deploy":
                    return "application/octet-stream";
                case "der":
                    return "application/x-x509-ca-cert";
                case "dgml":
                    return "application/xml";
                case "dib":
                    return "image/bmp";
                case "dif":
                    return "video/x-dv";
                case "dir":
                    return "application/x-director";
                case "disco":
                    return "text/xml";
                case "dll":
                    return "application/x-msdownload";
                case "dll.config":
                    return "text/xml";
                case "dlm":
                    return "text/dlm";
                case "doc":
                    return "application/msword";
                case "docm":
                    return "application/vnd.ms-word.document.macroenabled.12";
                case "docx":
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case "dot":
                    return "application/msword";
                case "dotm":
                    return "application/vnd.ms-word.template.macroenabled.12";
                case "dotx":
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
                case "dsp":
                    return "application/octet-stream";
                case "dsw":
                    return "text/plain";
                case "dtd":
                    return "text/xml";
                case "dtsconfig":
                    return "text/xml";
                case "dv":
                    return "video/x-dv";
                case "dvi":
                    return "application/x-dvi";
                case "dwf":
                    return "drawing/x-dwf";
                case "dwp":
                    return "application/octet-stream";
                case "dxr":
                    return "application/x-director";
                case "eml":
                    return "message/rfc822";
                case "emz":
                    return "application/octet-stream";
                case "eot":
                    return "application/octet-stream";
                case "eps":
                    return "application/postscript";
                case "etl":
                    return "application/etl";
                case "etx":
                    return "text/x-setext";
                case "evy":
                    return "application/envoy";
                case "exe":
                    return "application/octet-stream";
                case "exe.config":
                    return "text/xml";
                case "fdf":
                    return "application/vnd.fdf";
                case "fif":
                    return "application/fractals";
                case "filters":
                    return "application/xml";
                case "fla":
                    return "application/octet-stream";
                case "flr":
                    return "x-world/x-vrml";
                case "flv":
                    return "video/x-flv";
                case "fsscript":
                    return "application/fsharp-script";
                case "fsx":
                    return "application/fsharp-script";
                case "generictest":
                    return "application/xml";
                case "gif":
                    return "image/gif";
                case "group":
                    return "text/x-ms-group";
                case "gsm":
                    return "audio/x-gsm";
                case "gtar":
                    return "application/x-gtar";
                case "gz":
                    return "application/x-gzip";
                case "h":
                    return "text/plain";
                case "hdf":
                    return "application/x-hdf";
                case "hdml":
                    return "text/x-hdml";
                case "hhc":
                    return "application/x-oleobject";
                case "hhk":
                    return "application/octet-stream";
                case "hhp":
                    return "application/octet-stream";
                case "hlp":
                    return "application/winhlp";
                case "hpp":
                    return "text/plain";
                case "hqx":
                    return "application/mac-binhex40";
                case "hta":
                    return "application/hta";
                case "htc":
                    return "text/x-component";
                case "htm":
                    return "text/html";
                case "html":
                    return "text/html";
                case "htt":
                    return "text/webviewhtml";
                case "hxa":
                    return "application/xml";
                case "hxc":
                    return "application/xml";
                case "hxd":
                    return "application/octet-stream";
                case "hxe":
                    return "application/xml";
                case "hxf":
                    return "application/xml";
                case "hxh":
                    return "application/octet-stream";
                case "hxi":
                    return "application/octet-stream";
                case "hxk":
                    return "application/xml";
                case "hxq":
                    return "application/octet-stream";
                case "hxr":
                    return "application/octet-stream";
                case "hxs":
                    return "application/octet-stream";
                case "hxt":
                    return "text/html";
                case "hxv":
                    return "application/xml";
                case "hxw":
                    return "application/octet-stream";
                case "hxx":
                    return "text/plain";
                case "i":
                    return "text/plain";
                case "ico":
                    return "image/x-icon";
                case "ics":
                    return "application/octet-stream";
                case "idl":
                    return "text/plain";
                case "ief":
                    return "image/ief";
                case "iii":
                    return "application/x-iphone";
                case "inc":
                    return "text/plain";
                case "inf":
                    return "application/octet-stream";
                case "inl":
                    return "text/plain";
                case "ins":
                    return "application/x-internet-signup";
                case "ipa":
                    return "application/x-itunes-ipa";
                case "ipg":
                    return "application/x-itunes-ipg";
                case "ipproj":
                    return "text/plain";
                case "ipsw":
                    return "application/x-itunes-ipsw";
                case "iqy":
                    return "text/x-ms-iqy";
                case "isp":
                    return "application/x-internet-signup";
                case "ite":
                    return "application/x-itunes-ite";
                case "itlp":
                    return "application/x-itunes-itlp";
                case "itms":
                    return "application/x-itunes-itms";
                case "itpc":
                    return "application/x-itunes-itpc";
                case "ivf":
                    return "video/x-ivf";
                case "jar":
                    return "application/java-archive";
                case "java":
                    return "application/octet-stream";
                case "jck":
                    return "application/liquidmotion";
                case "jcz":
                    return "application/liquidmotion";
                case "jfif":
                    return "image/pjpeg";
                case "jnlp":
                    return "application/x-java-jnlp-file";
                case "jpb":
                    return "application/octet-stream";
                case "jpe":
                    return "image/jpeg";
                case "jpeg":
                    return "image/jpeg";
                case "jpg":
                    return "image/jpeg";
                case "js":
                    return "application/x-javascript";
                case "jsx":
                    return "text/jscript";
                case "jsxbin":
                    return "text/plain";
                case "latex":
                    return "application/x-latex";
                case "library-ms":
                    return "application/windows-library+xml";
                case "lit":
                    return "application/x-ms-reader";
                case "loadtest":
                    return "application/xml";
                case "lpk":
                    return "application/octet-stream";
                case "lsf":
                    return "video/x-la-asf";
                case "lst":
                    return "text/plain";
                case "lsx":
                    return "video/x-la-asf";
                case "lzh":
                    return "application/octet-stream";
                case "m13":
                    return "application/x-msmediaview";
                case "m14":
                    return "application/x-msmediaview";
                case "m1v":
                    return "video/mpeg";
                case "m2t":
                    return "video/vnd.dlna.mpeg-tts";
                case "m2ts":
                    return "video/vnd.dlna.mpeg-tts";
                case "m2v":
                    return "video/mpeg";
                case "m3u":
                    return "audio/x-mpegurl";
                case "m3u8":
                    return "audio/x-mpegurl";
                case "m4a":
                    return "audio/m4a";
                case "m4b":
                    return "audio/m4b";
                case "m4p":
                    return "audio/m4p";
                case "m4r":
                    return "audio/x-m4r";
                case "m4v":
                    return "video/x-m4v";
                case "mac":
                    return "image/x-macpaint";
                case "mak":
                    return "text/plain";
                case "man":
                    return "application/x-troff-man";
                case "manifest":
                    return "application/x-ms-manifest";
                case "map":
                    return "text/plain";
                case "master":
                    return "application/xml";
                case "mda":
                    return "application/msaccess";
                case "mdb":
                    return "application/x-msaccess";
                case "mde":
                    return "application/msaccess";
                case "mdp":
                    return "application/octet-stream";
                case "me":
                    return "application/x-troff-me";
                case "mfp":
                    return "application/x-shockwave-flash";
                case "mht":
                    return "message/rfc822";
                case "mhtml":
                    return "message/rfc822";
                case "mid":
                    return "audio/mid";
                case "midi":
                    return "audio/mid";
                case "mix":
                    return "application/octet-stream";
                case "mk":
                    return "text/plain";
                case "mmf":
                    return "application/x-smaf";
                case "mno":
                    return "text/xml";
                case "mny":
                    return "application/x-msmoney";
                case "mod":
                    return "video/mpeg";
                case "mov":
                    return "video/quicktime";
                case "movie":
                    return "video/x-sgi-movie";
                case "mp2":
                    return "video/mpeg";
                case "mp2v":
                    return "video/mpeg";
                case "mp3":
                    return "audio/mpeg";
                case "mp4":
                    return "video/mp4";
                case "mp4v":
                    return "video/mp4";
                case "mpa":
                    return "video/mpeg";
                case "mpe":
                    return "video/mpeg";
                case "mpeg":
                    return "video/mpeg";
                case "mpf":
                    return "application/vnd.ms-mediapackage";
                case "mpg":
                    return "video/mpeg";
                case "mpp":
                    return "application/vnd.ms-project";
                case "mpv2":
                    return "video/mpeg";
                case "mqv":
                    return "video/quicktime";
                case "ms":
                    return "application/x-troff-ms";
                case "msi":
                    return "application/octet-stream";
                case "mso":
                    return "application/octet-stream";
                case "mts":
                    return "video/vnd.dlna.mpeg-tts";
                case "mtx":
                    return "application/xml";
                case "mvb":
                    return "application/x-msmediaview";
                case "mvc":
                    return "application/x-miva-compiled";
                case "mxp":
                    return "application/x-mmxp";
                case "nc":
                    return "application/x-netcdf";
                case "nsc":
                    return "video/x-ms-asf";
                case "nws":
                    return "message/rfc822";
                case "ocx":
                    return "application/octet-stream";
                case "oda":
                    return "application/oda";
                case "odc":
                    return "text/x-ms-odc";
                case "odh":
                    return "text/plain";
                case "odl":
                    return "text/plain";
                case "odp":
                    return "application/vnd.oasis.opendocument.presentation";
                case "ods":
                    return "application/oleobject";
                case "odt":
                    return "application/vnd.oasis.opendocument.text";
                case "one":
                    return "application/onenote";
                case "onea":
                    return "application/onenote";
                case "onepkg":
                    return "application/onenote";
                case "onetmp":
                    return "application/onenote";
                case "onetoc":
                    return "application/onenote";
                case "onetoc2":
                    return "application/onenote";
                case "orderedtest":
                    return "application/xml";
                case "osdx":
                    return "application/opensearchdescription+xml";
                case "p10":
                    return "application/pkcs10";
                case "p12":
                    return "application/x-pkcs12";
                case "p7b":
                    return "application/x-pkcs7-certificates";
                case "p7c":
                    return "application/pkcs7-mime";
                case "p7m":
                    return "application/pkcs7-mime";
                case "p7r":
                    return "application/x-pkcs7-certreqresp";
                case "p7s":
                    return "application/pkcs7-signature";
                case "pbm":
                    return "image/x-portable-bitmap";
                case "pcast":
                    return "application/x-podcast";
                case "pct":
                    return "image/pict";
                case "pcx":
                    return "application/octet-stream";
                case "pcz":
                    return "application/octet-stream";
                case "pdf":
                    return "application/pdf";
                case "pfb":
                    return "application/octet-stream";
                case "pfm":
                    return "application/octet-stream";
                case "pfx":
                    return "application/x-pkcs12";
                case "pgm":
                    return "image/x-portable-graymap";
                case "pic":
                    return "image/pict";
                case "pict":
                    return "image/pict";
                case "pkgdef":
                    return "text/plain";
                case "pkgundef":
                    return "text/plain";
                case "pko":
                    return "application/vnd.ms-pki.pko";
                case "pls":
                    return "audio/scpls";
                case "pma":
                    return "application/x-perfmon";
                case "pmc":
                    return "application/x-perfmon";
                case "pml":
                    return "application/x-perfmon";
                case "pmr":
                    return "application/x-perfmon";
                case "pmw":
                    return "application/x-perfmon";
                case "png":
                    return "image/png";
                case "pnm":
                    return "image/x-portable-anymap";
                case "pnt":
                    return "image/x-macpaint";
                case "pntg":
                    return "image/x-macpaint";
                case "pnz":
                    return "image/png";
                case "pot":
                    return "application/vnd.ms-powerpoint";
                case "potm":
                    return "application/vnd.ms-powerpoint.template.macroenabled.12";
                case "potx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.template";
                case "ppa":
                    return "application/vnd.ms-powerpoint";
                case "ppam":
                    return "application/vnd.ms-powerpoint.addin.macroenabled.12";
                case "ppm":
                    return "image/x-portable-pixmap";
                case "pps":
                    return "application/vnd.ms-powerpoint";
                case "ppsm":
                    return "application/vnd.ms-powerpoint.slideshow.macroenabled.12";
                case "ppsx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
                case "ppt":
                    return "application/vnd.ms-powerpoint";
                case "pptm":
                    return "application/vnd.ms-powerpoint.presentation.macroenabled.12";
                case "pptx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                case "prf":
                    return "application/pics-rules";
                case "prm":
                    return "application/octet-stream";
                case "prx":
                    return "application/octet-stream";
                case "ps":
                    return "application/postscript";
                case "psc1":
                    return "application/powershell";
                case "psd":
                    return "application/octet-stream";
                case "psess":
                    return "application/xml";
                case "psm":
                    return "application/octet-stream";
                case "psp":
                    return "application/octet-stream";
                case "pub":
                    return "application/x-mspublisher";
                case "pwz":
                    return "application/vnd.ms-powerpoint";
                case "qht":
                    return "text/x-html-insertion";
                case "qhtm":
                    return "text/x-html-insertion";
                case "qt":
                    return "video/quicktime";
                case "qti":
                    return "image/x-quicktime";
                case "qtif":
                    return "image/x-quicktime";
                case "qtl":
                    return "application/x-quicktimeplayer";
                case "qxd":
                    return "application/octet-stream";
                case "ra":
                    return "audio/x-pn-realaudio";
                case "ram":
                    return "audio/x-pn-realaudio";
                case "rar":
                    return "application/octet-stream";
                case "ras":
                    return "image/x-cmu-raster";
                case "rat":
                    return "application/rat-file";
                case "rc":
                    return "text/plain";
                case "rc2":
                    return "text/plain";
                case "rct":
                    return "text/plain";
                case "rdlc":
                    return "application/xml";
                case "resx":
                    return "application/xml";
                case "rf":
                    return "image/vnd.rn-realflash";
                case "rgb":
                    return "image/x-rgb";
                case "rgs":
                    return "text/plain";
                case "rm":
                    return "application/vnd.rn-realmedia";
                case "rmi":
                    return "audio/mid";
                case "rmp":
                    return "application/vnd.rn-rn_music_package";
                case "roff":
                    return "application/x-troff";
                case "rpm":
                    return "audio/x-pn-realaudio-plugin";
                case "rqy":
                    return "text/x-ms-rqy";
                case "rtf":
                    return "application/rtf";
                case "rtx":
                    return "text/richtext";
                case "ruleset":
                    return "application/xml";
                case "s":
                    return "text/plain";
                case "safariextz":
                    return "application/x-safari-safariextz";
                case "scd":
                    return "application/x-msschedule";
                case "sct":
                    return "text/scriptlet";
                case "sd2":
                    return "audio/x-sd2";
                case "sdp":
                    return "application/sdp";
                case "sea":
                    return "application/octet-stream";
                case "searchconnector-ms":
                    return "application/windows-search-connector+xml";
                case "setpay":
                    return "application/set-payment-initiation";
                case "setreg":
                    return "application/set-registration-initiation";
                case "settings":
                    return "application/xml";
                case "sgimb":
                    return "application/x-sgimb";
                case "sgml":
                    return "text/sgml";
                case "sh":
                    return "application/x-sh";
                case "shar":
                    return "application/x-shar";
                case "shtml":
                    return "text/html";
                case "sit":
                    return "application/x-stuffit";
                case "sitemap":
                    return "application/xml";
                case "skin":
                    return "application/xml";
                case "sldm":
                    return "application/vnd.ms-powerpoint.slide.macroenabled.12";
                case "sldx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.slide";
                case "slk":
                    return "application/vnd.ms-excel";
                case "sln":
                    return "text/plain";
                case "slupkg-ms":
                    return "application/x-ms-license";
                case "smd":
                    return "audio/x-smd";
                case "smi":
                    return "application/octet-stream";
                case "smx":
                    return "audio/x-smd";
                case "smz":
                    return "audio/x-smd";
                case "snd":
                    return "audio/basic";
                case "snippet":
                    return "application/xml";
                case "snp":
                    return "application/octet-stream";
                case "sol":
                    return "text/plain";
                case "sor":
                    return "text/plain";
                case "spc":
                    return "application/x-pkcs7-certificates";
                case "spl":
                    return "application/futuresplash";
                case "src":
                    return "application/x-wais-source";
                case "srf":
                    return "text/plain";
                case "ssisdeploymentmanifest":
                    return "text/xml";
                case "ssm":
                    return "application/streamingmedia";
                case "sst":
                    return "application/vnd.ms-pki.certstore";
                case "stl":
                    return "application/vnd.ms-pki.stl";
                case "sv4cpio":
                    return "application/x-sv4cpio";
                case "sv4crc":
                    return "application/x-sv4crc";
                case "svc":
                    return "application/xml";
                case "swf":
                    return "application/x-shockwave-flash";
                case "t":
                    return "application/x-troff";
                case "tar":
                    return "application/x-tar";
                case "tcl":
                    return "application/x-tcl";
                case "testrunconfig":
                    return "application/xml";
                case "testsettings":
                    return "application/xml";
                case "tex":
                    return "application/x-tex";
                case "texi":
                    return "application/x-texinfo";
                case "texinfo":
                    return "application/x-texinfo";
                case "tgz":
                    return "application/x-compressed";
                case "thmx":
                    return "application/vnd.ms-officetheme";
                case "thn":
                    return "application/octet-stream";
                case "tif":
                    return "image/tiff";
                case "tiff":
                    return "image/tiff";
                case "tlh":
                    return "text/plain";
                case "tli":
                    return "text/plain";
                case "toc":
                    return "application/octet-stream";
                case "tr":
                    return "application/x-troff";
                case "trm":
                    return "application/x-msterminal";
                case "trx":
                    return "application/xml";
                case "ts":
                    return "video/vnd.dlna.mpeg-tts";
                case "tsv":
                    return "text/tab-separated-values";
                case "ttf":
                    return "application/octet-stream";
                case "tts":
                    return "video/vnd.dlna.mpeg-tts";
                case "txt":
                    return "text/plain";
                case "u32":
                    return "application/octet-stream";
                case "uls":
                    return "text/iuls";
                case "user":
                    return "text/plain";
                case "ustar":
                    return "application/x-ustar";
                case "vb":
                    return "text/plain";
                case "vbdproj":
                    return "text/plain";
                case "vbk":
                    return "video/mpeg";
                case "vbproj":
                    return "text/plain";
                case "vbs":
                    return "text/vbscript";
                case "vcf":
                    return "text/x-vcard";
                case "vcproj":
                    return "application/xml";
                case "vcs":
                    return "text/plain";
                case "vcxproj":
                    return "application/xml";
                case "vddproj":
                    return "text/plain";
                case "vdp":
                    return "text/plain";
                case "vdproj":
                    return "text/plain";
                case "vdx":
                    return "application/vnd.ms-visio.viewer";
                case "vml":
                    return "text/xml";
                case "vscontent":
                    return "application/xml";
                case "vsct":
                    return "text/xml";
                case "vsd":
                    return "application/vnd.visio";
                case "vsi":
                    return "application/ms-vsi";
                case "vsix":
                    return "application/vsix";
                case "vsixlangpack":
                    return "text/xml";
                case "vsixmanifest":
                    return "text/xml";
                case "vsmdi":
                    return "application/xml";
                case "vspscc":
                    return "text/plain";
                case "vss":
                    return "application/vnd.visio";
                case "vsscc":
                    return "text/plain";
                case "vssettings":
                    return "text/xml";
                case "vssscc":
                    return "text/plain";
                case "vst":
                    return "application/vnd.visio";
                case "vstemplate":
                    return "text/xml";
                case "vsto":
                    return "application/x-ms-vsto";
                case "vsw":
                    return "application/vnd.visio";
                case "vsx":
                    return "application/vnd.visio";
                case "vtx":
                    return "application/vnd.visio";
                case "wav":
                    return "audio/wav";
                case "wave":
                    return "audio/wav";
                case "wax":
                    return "audio/x-ms-wax";
                case "wbk":
                    return "application/msword";
                case "wbmp":
                    return "image/vnd.wap.wbmp";
                case "wcm":
                    return "application/vnd.ms-works";
                case "wdb":
                    return "application/vnd.ms-works";
                case "wdp":
                    return "image/vnd.ms-photo";
                case "webarchive":
                    return "application/x-safari-webarchive";
                case "webtest":
                    return "application/xml";
                case "wiq":
                    return "application/xml";
                case "wiz":
                    return "application/msword";
                case "wks":
                    return "application/vnd.ms-works";
                case "wlmp":
                    return "application/wlmoviemaker";
                case "wlpginstall":
                    return "application/x-wlpg-detect";
                case "wlpginstall3":
                    return "application/x-wlpg3-detect";
                case "wm":
                    return "video/x-ms-wm";
                case "wma":
                    return "audio/x-ms-wma";
                case "wmd":
                    return "application/x-ms-wmd";
                case "wmf":
                    return "application/x-msmetafile";
                case "wml":
                    return "text/vnd.wap.wml";
                case "wmlc":
                    return "application/vnd.wap.wmlc";
                case "wmls":
                    return "text/vnd.wap.wmlscript";
                case "wmlsc":
                    return "application/vnd.wap.wmlscriptc";
                case "wmp":
                    return "video/x-ms-wmp";
                case "wmv":
                    return "video/x-ms-wmv";
                case "wmx":
                    return "video/x-ms-wmx";
                case "wmz":
                    return "application/x-ms-wmz";
                case "wpl":
                    return "application/vnd.ms-wpl";
                case "wps":
                    return "application/vnd.ms-works";
                case "wri":
                    return "application/x-mswrite";
                case "wrl":
                    return "x-world/x-vrml";
                case "wrz":
                    return "x-world/x-vrml";
                case "wsc":
                    return "text/scriptlet";
                case "wsdl":
                    return "text/xml";
                case "wvx":
                    return "video/x-ms-wvx";
                case "x":
                    return "application/directx";
                case "xaf":
                    return "x-world/x-vrml";
                case "xaml":
                    return "application/xaml+xml";
                case "xap":
                    return "application/x-silverlight-app";
                case "xbap":
                    return "application/x-ms-xbap";
                case "xbm":
                    return "image/x-xbitmap";
                case "xdr":
                    return "text/plain";
                case "xht":
                    return "application/xhtml+xml";
                case "xhtml":
                    return "application/xhtml+xml";
                case "xla":
                    return "application/vnd.ms-excel";
                case "xlam":
                    return "application/vnd.ms-excel.addin.macroenabled.12";
                case "xlc":
                    return "application/vnd.ms-excel";
                case "xld":
                    return "application/vnd.ms-excel";
                case "xlk":
                    return "application/vnd.ms-excel";
                case "xll":
                    return "application/vnd.ms-excel";
                case "xlm":
                    return "application/vnd.ms-excel";
                case "xls":
                    return "application/vnd.ms-excel";
                case "xlsb":
                    return "application/vnd.ms-excel.sheet.binary.macroenabled.12";
                case "xlsm":
                    return "application/vnd.ms-excel.sheet.macroenabled.12";
                case "xlsx":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                case "xlt":
                    return "application/vnd.ms-excel";
                case "xltm":
                    return "application/vnd.ms-excel.template.macroenabled.12";
                case "xltx":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
                case "xlw":
                    return "application/vnd.ms-excel";
                case "xml":
                    return "text/xml";
                case "xmta":
                    return "application/xml";
                case "xof":
                    return "x-world/x-vrml";
                case "xoml":
                    return "text/plain";
                case "xpm":
                    return "image/x-xpixmap";
                case "xps":
                    return "application/vnd.ms-xpsdocument";
                case "xrm-ms":
                    return "text/xml";
                case "xsc":
                    return "application/xml";
                case "xsd":
                    return "text/xml";
                case "xsf":
                    return "text/xml";
                case "xsl":
                    return "text/xml";
                case "xslt":
                    return "text/xml";
                case "xsn":
                    return "application/octet-stream";
                case "xss":
                    return "application/xml";
                case "xtp":
                    return "application/octet-stream";
                case "xwd":
                    return "image/x-xwindowdump";
                case "z":
                    return "application/x-compress";
                case "zip":
                    return "application/x-zip-compressed";

                #endregion

                default:
                    return null;
            }
        }

        private static IDictionary<string, string> _mappings =
            new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
                {
                    #region Big freaking list of mime types
                    // combination of values from Windows 7 Registry and 
                    // from C:\Windows\System32\inetsrv\config\applicationHost.config
                    // some added, including .7z and .dat
                    {".323", "text/h323"},
                    {".3g2", "video/3gpp2"},
                    {".3gp", "video/3gpp"},
                    {".3gp2", "video/3gpp2"},
                    {".3gpp", "video/3gpp"},
                    {".7z", "application/x-7z-compressed"},
                    {".aa", "audio/audible"},
                    {".AAC", "audio/aac"},
                    {".aaf", "application/octet-stream"},
                    {".aax", "audio/vnd.audible.aax"},
                    {".ac3", "audio/ac3"},
                    {".aca", "application/octet-stream"},
                    {".accda", "application/msaccess.addin"},
                    {".accdb", "application/msaccess"},
                    {".accdc", "application/msaccess.cab"},
                    {".accde", "application/msaccess"},
                    {".accdr", "application/msaccess.runtime"},
                    {".accdt", "application/msaccess"},
                    {".accdw", "application/msaccess.webapplication"},
                    {".accft", "application/msaccess.ftemplate"},
                    {".acx", "application/internet-property-stream"},
                    {".AddIn", "text/xml"},
                    {".ade", "application/msaccess"},
                    {".adobebridge", "application/x-bridge-url"},
                    {".adp", "application/msaccess"},
                    {".ADT", "audio/vnd.dlna.adts"},
                    {".ADTS", "audio/aac"},
                    {".afm", "application/octet-stream"},
                    {".ai", "application/postscript"},
                    {".aif", "audio/x-aiff"},
                    {".aifc", "audio/aiff"},
                    {".aiff", "audio/aiff"},
                    {".air", "application/vnd.adobe.air-application-installer-package+zip"},
                    {".amc", "application/x-mpeg"},
                    {".application", "application/x-ms-application"},
                    {".art", "image/x-jg"},
                    {".asa", "application/xml"},
                    {".asax", "application/xml"},
                    {".ascx", "application/xml"},
                    {".asd", "application/octet-stream"},
                    {".asf", "video/x-ms-asf"},
                    {".ashx", "application/xml"},
                    {".asi", "application/octet-stream"},
                    {".asm", "text/plain"},
                    {".asmx", "application/xml"},
                    {".aspx", "application/xml"},
                    {".asr", "video/x-ms-asf"},
                    {".asx", "video/x-ms-asf"},
                    {".atom", "application/atom+xml"},
                    {".au", "audio/basic"},
                    {".avi", "video/x-msvideo"},
                    {".axs", "application/olescript"},
                    {".bas", "text/plain"},
                    {".bcpio", "application/x-bcpio"},
                    {".bin", "application/octet-stream"},
                    {".bmp", "image/bmp"},
                    {".c", "text/plain"},
                    {".cab", "application/octet-stream"},
                    {".caf", "audio/x-caf"},
                    {".calx", "application/vnd.ms-office.calx"},
                    {".cat", "application/vnd.ms-pki.seccat"},
                    {".cc", "text/plain"},
                    {".cd", "text/plain"},
                    {".cdda", "audio/aiff"},
                    {".cdf", "application/x-cdf"},
                    {".cer", "application/x-x509-ca-cert"},
                    {".chm", "application/octet-stream"},
                    {".class", "application/x-java-applet"},
                    {".clp", "application/x-msclip"},
                    {".cmx", "image/x-cmx"},
                    {".cnf", "text/plain"},
                    {".cod", "image/cis-cod"},
                    {".config", "application/xml"},
                    {".contact", "text/x-ms-contact"},
                    {".coverage", "application/xml"},
                    {".cpio", "application/x-cpio"},
                    {".cpp", "text/plain"},
                    {".crd", "application/x-mscardfile"},
                    {".crl", "application/pkix-crl"},
                    {".crt", "application/x-x509-ca-cert"},
                    {".cs", "text/plain"},
                    {".csdproj", "text/plain"},
                    {".csh", "application/x-csh"},
                    {".csproj", "text/plain"},
                    {".css", "text/css"},
                    {".csv", "text/csv"},
                    {".cur", "application/octet-stream"},
                    {".cxx", "text/plain"},
                    {".dat", "application/octet-stream"},
                    {".datasource", "application/xml"},
                    {".dbproj", "text/plain"},
                    {".dcr", "application/x-director"},
                    {".def", "text/plain"},
                    {".deploy", "application/octet-stream"},
                    {".der", "application/x-x509-ca-cert"},
                    {".dgml", "application/xml"},
                    {".dib", "image/bmp"},
                    {".dif", "video/x-dv"},
                    {".dir", "application/x-director"},
                    {".disco", "text/xml"},
                    {".dll", "application/x-msdownload"},
                    {".dll.config", "text/xml"},
                    {".dlm", "text/dlm"},
                    {".doc", "application/msword"},
                    {".docm", "application/vnd.ms-word.document.macroEnabled.12"},
                    {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                    {".dot", "application/msword"},
                    {".dotm", "application/vnd.ms-word.template.macroEnabled.12"},
                    {".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
                    {".dsp", "application/octet-stream"},
                    {".dsw", "text/plain"},
                    {".dtd", "text/xml"},
                    {".dtsConfig", "text/xml"},
                    {".dv", "video/x-dv"},
                    {".dvi", "application/x-dvi"},
                    {".dwf", "drawing/x-dwf"},
                    {".dwp", "application/octet-stream"},
                    {".dxr", "application/x-director"},
                    {".eml", "message/rfc822"},
                    {".emz", "application/octet-stream"},
                    {".eot", "application/octet-stream"},
                    {".eps", "application/postscript"},
                    {".etl", "application/etl"},
                    {".etx", "text/x-setext"},
                    {".evy", "application/envoy"},
                    {".exe", "application/octet-stream"},
                    {".exe.config", "text/xml"},
                    {".fdf", "application/vnd.fdf"},
                    {".fif", "application/fractals"},
                    {".filters", "Application/xml"},
                    {".fla", "application/octet-stream"},
                    {".flr", "x-world/x-vrml"},
                    {".flv", "video/x-flv"},
                    {".fsscript", "application/fsharp-script"},
                    {".fsx", "application/fsharp-script"},
                    {".generictest", "application/xml"},
                    {".gif", "image/gif"},
                    {".group", "text/x-ms-group"},
                    {".gsm", "audio/x-gsm"},
                    {".gtar", "application/x-gtar"},
                    {".gz", "application/x-gzip"},
                    {".h", "text/plain"},
                    {".hdf", "application/x-hdf"},
                    {".hdml", "text/x-hdml"},
                    {".hhc", "application/x-oleobject"},
                    {".hhk", "application/octet-stream"},
                    {".hhp", "application/octet-stream"},
                    {".hlp", "application/winhlp"},
                    {".hpp", "text/plain"},
                    {".hqx", "application/mac-binhex40"},
                    {".hta", "application/hta"},
                    {".htc", "text/x-component"},
                    {".htm", "text/html"},
                    {".html", "text/html"},
                    {".htt", "text/webviewhtml"},
                    {".hxa", "application/xml"},
                    {".hxc", "application/xml"},
                    {".hxd", "application/octet-stream"},
                    {".hxe", "application/xml"},
                    {".hxf", "application/xml"},
                    {".hxh", "application/octet-stream"},
                    {".hxi", "application/octet-stream"},
                    {".hxk", "application/xml"},
                    {".hxq", "application/octet-stream"},
                    {".hxr", "application/octet-stream"},
                    {".hxs", "application/octet-stream"},
                    {".hxt", "text/html"},
                    {".hxv", "application/xml"},
                    {".hxw", "application/octet-stream"},
                    {".hxx", "text/plain"},
                    {".i", "text/plain"},
                    {".ico", "image/x-icon"},
                    {".ics", "application/octet-stream"},
                    {".idl", "text/plain"},
                    {".ief", "image/ief"},
                    {".iii", "application/x-iphone"},
                    {".inc", "text/plain"},
                    {".inf", "application/octet-stream"},
                    {".inl", "text/plain"},
                    {".ins", "application/x-internet-signup"},
                    {".ipa", "application/x-itunes-ipa"},
                    {".ipg", "application/x-itunes-ipg"},
                    {".ipproj", "text/plain"},
                    {".ipsw", "application/x-itunes-ipsw"},
                    {".iqy", "text/x-ms-iqy"},
                    {".isp", "application/x-internet-signup"},
                    {".ite", "application/x-itunes-ite"},
                    {".itlp", "application/x-itunes-itlp"},
                    {".itms", "application/x-itunes-itms"},
                    {".itpc", "application/x-itunes-itpc"},
                    {".IVF", "video/x-ivf"},
                    {".jar", "application/java-archive"},
                    {".java", "application/octet-stream"},
                    {".jck", "application/liquidmotion"},
                    {".jcz", "application/liquidmotion"},
                    {".jfif", "image/pjpeg"},
                    {".jnlp", "application/x-java-jnlp-file"},
                    {".jpb", "application/octet-stream"},
                    {".jpe", "image/jpeg"},
                    {".jpeg", "image/jpeg"},
                    {".jpg", "image/jpeg"},
                    {".js", "application/x-javascript"},
                    {".jsx", "text/jscript"},
                    {".jsxbin", "text/plain"},
                    {".latex", "application/x-latex"},
                    {".library-ms", "application/windows-library+xml"},
                    {".lit", "application/x-ms-reader"},
                    {".loadtest", "application/xml"},
                    {".lpk", "application/octet-stream"},
                    {".lsf", "video/x-la-asf"},
                    {".lst", "text/plain"},
                    {".lsx", "video/x-la-asf"},
                    {".lzh", "application/octet-stream"},
                    {".m13", "application/x-msmediaview"},
                    {".m14", "application/x-msmediaview"},
                    {".m1v", "video/mpeg"},
                    {".m2t", "video/vnd.dlna.mpeg-tts"},
                    {".m2ts", "video/vnd.dlna.mpeg-tts"},
                    {".m2v", "video/mpeg"},
                    {".m3u", "audio/x-mpegurl"},
                    {".m3u8", "audio/x-mpegurl"},
                    {".m4a", "audio/m4a"},
                    {".m4b", "audio/m4b"},
                    {".m4p", "audio/m4p"},
                    {".m4r", "audio/x-m4r"},
                    {".m4v", "video/x-m4v"},
                    {".mac", "image/x-macpaint"},
                    {".mak", "text/plain"},
                    {".man", "application/x-troff-man"},
                    {".manifest", "application/x-ms-manifest"},
                    {".map", "text/plain"},
                    {".master", "application/xml"},
                    {".mda", "application/msaccess"},
                    {".mdb", "application/x-msaccess"},
                    {".mde", "application/msaccess"},
                    {".mdp", "application/octet-stream"},
                    {".me", "application/x-troff-me"},
                    {".mfp", "application/x-shockwave-flash"},
                    {".mht", "message/rfc822"},
                    {".mhtml", "message/rfc822"},
                    {".mid", "audio/mid"},
                    {".midi", "audio/mid"},
                    {".mix", "application/octet-stream"},
                    {".mk", "text/plain"},
                    {".mmf", "application/x-smaf"},
                    {".mno", "text/xml"},
                    {".mny", "application/x-msmoney"},
                    {".mod", "video/mpeg"},
                    {".mov", "video/quicktime"},
                    {".movie", "video/x-sgi-movie"},
                    {".mp2", "video/mpeg"},
                    {".mp2v", "video/mpeg"},
                    {".mp3", "audio/mpeg"},
                    {".mp4", "video/mp4"},
                    {".mp4v", "video/mp4"},
                    {".mpa", "video/mpeg"},
                    {".mpe", "video/mpeg"},
                    {".mpeg", "video/mpeg"},
                    {".mpf", "application/vnd.ms-mediapackage"},
                    {".mpg", "video/mpeg"},
                    {".mpp", "application/vnd.ms-project"},
                    {".mpv2", "video/mpeg"},
                    {".mqv", "video/quicktime"},
                    {".ms", "application/x-troff-ms"},
                    {".msi", "application/octet-stream"},
                    {".mso", "application/octet-stream"},
                    {".mts", "video/vnd.dlna.mpeg-tts"},
                    {".mtx", "application/xml"},
                    {".mvb", "application/x-msmediaview"},
                    {".mvc", "application/x-miva-compiled"},
                    {".mxp", "application/x-mmxp"},
                    {".nc", "application/x-netcdf"},
                    {".nsc", "video/x-ms-asf"},
                    {".nws", "message/rfc822"},
                    {".ocx", "application/octet-stream"},
                    {".oda", "application/oda"},
                    {".odc", "text/x-ms-odc"},
                    {".odh", "text/plain"},
                    {".odl", "text/plain"},
                    {".odp", "application/vnd.oasis.opendocument.presentation"},
                    {".ods", "application/oleobject"},
                    {".odt", "application/vnd.oasis.opendocument.text"},
                    {".one", "application/onenote"},
                    {".onea", "application/onenote"},
                    {".onepkg", "application/onenote"},
                    {".onetmp", "application/onenote"},
                    {".onetoc", "application/onenote"},
                    {".onetoc2", "application/onenote"},
                    {".orderedtest", "application/xml"},
                    {".osdx", "application/opensearchdescription+xml"},
                    {".p10", "application/pkcs10"},
                    {".p12", "application/x-pkcs12"},
                    {".p7b", "application/x-pkcs7-certificates"},
                    {".p7c", "application/pkcs7-mime"},
                    {".p7m", "application/pkcs7-mime"},
                    {".p7r", "application/x-pkcs7-certreqresp"},
                    {".p7s", "application/pkcs7-signature"},
                    {".pbm", "image/x-portable-bitmap"},
                    {".pcast", "application/x-podcast"},
                    {".pct", "image/pict"},
                    {".pcx", "application/octet-stream"},
                    {".pcz", "application/octet-stream"},
                    {".pdf", "application/pdf"},
                    {".pfb", "application/octet-stream"},
                    {".pfm", "application/octet-stream"},
                    {".pfx", "application/x-pkcs12"},
                    {".pgm", "image/x-portable-graymap"},
                    {".pic", "image/pict"},
                    {".pict", "image/pict"},
                    {".pkgdef", "text/plain"},
                    {".pkgundef", "text/plain"},
                    {".pko", "application/vnd.ms-pki.pko"},
                    {".pls", "audio/scpls"},
                    {".pma", "application/x-perfmon"},
                    {".pmc", "application/x-perfmon"},
                    {".pml", "application/x-perfmon"},
                    {".pmr", "application/x-perfmon"},
                    {".pmw", "application/x-perfmon"},
                    {".png", "image/png"},
                    {".pnm", "image/x-portable-anymap"},
                    {".pnt", "image/x-macpaint"},
                    {".pntg", "image/x-macpaint"},
                    {".pnz", "image/png"},
                    {".pot", "application/vnd.ms-powerpoint"},
                    {".potm", "application/vnd.ms-powerpoint.template.macroEnabled.12"},
                    {".potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
                    {".ppa", "application/vnd.ms-powerpoint"},
                    {".ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12"},
                    {".ppm", "image/x-portable-pixmap"},
                    {".pps", "application/vnd.ms-powerpoint"},
                    {".ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
                    {".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
                    {".ppt", "application/vnd.ms-powerpoint"},
                    {".pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
                    {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
                    {".prf", "application/pics-rules"},
                    {".prm", "application/octet-stream"},
                    {".prx", "application/octet-stream"},
                    {".ps", "application/postscript"},
                    {".psc1", "application/PowerShell"},
                    {".psd", "application/octet-stream"},
                    {".psess", "application/xml"},
                    {".psm", "application/octet-stream"},
                    {".psp", "application/octet-stream"},
                    {".pub", "application/x-mspublisher"},
                    {".pwz", "application/vnd.ms-powerpoint"},
                    {".qht", "text/x-html-insertion"},
                    {".qhtm", "text/x-html-insertion"},
                    {".qt", "video/quicktime"},
                    {".qti", "image/x-quicktime"},
                    {".qtif", "image/x-quicktime"},
                    {".qtl", "application/x-quicktimeplayer"},
                    {".qxd", "application/octet-stream"},
                    {".ra", "audio/x-pn-realaudio"},
                    {".ram", "audio/x-pn-realaudio"},
                    {".rar", "application/octet-stream"},
                    {".ras", "image/x-cmu-raster"},
                    {".rat", "application/rat-file"},
                    {".rc", "text/plain"},
                    {".rc2", "text/plain"},
                    {".rct", "text/plain"},
                    {".rdlc", "application/xml"},
                    {".resx", "application/xml"},
                    {".rf", "image/vnd.rn-realflash"},
                    {".rgb", "image/x-rgb"},
                    {".rgs", "text/plain"},
                    {".rm", "application/vnd.rn-realmedia"},
                    {".rmi", "audio/mid"},
                    {".rmp", "application/vnd.rn-rn_music_package"},
                    {".roff", "application/x-troff"},
                    {".rpm", "audio/x-pn-realaudio-plugin"},
                    {".rqy", "text/x-ms-rqy"},
                    {".rtf", "application/rtf"},
                    {".rtx", "text/richtext"},
                    {".ruleset", "application/xml"},
                    {".s", "text/plain"},
                    {".safariextz", "application/x-safari-safariextz"},
                    {".scd", "application/x-msschedule"},
                    {".sct", "text/scriptlet"},
                    {".sd2", "audio/x-sd2"},
                    {".sdp", "application/sdp"},
                    {".sea", "application/octet-stream"},
                    {".searchConnector-ms", "application/windows-search-connector+xml"},
                    {".setpay", "application/set-payment-initiation"},
                    {".setreg", "application/set-registration-initiation"},
                    {".settings", "application/xml"},
                    {".sgimb", "application/x-sgimb"},
                    {".sgml", "text/sgml"},
                    {".sh", "application/x-sh"},
                    {".shar", "application/x-shar"},
                    {".shtml", "text/html"},
                    {".sit", "application/x-stuffit"},
                    {".sitemap", "application/xml"},
                    {".skin", "application/xml"},
                    {".sldm", "application/vnd.ms-powerpoint.slide.macroEnabled.12"},
                    {".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide"},
                    {".slk", "application/vnd.ms-excel"},
                    {".sln", "text/plain"},
                    {".slupkg-ms", "application/x-ms-license"},
                    {".smd", "audio/x-smd"},
                    {".smi", "application/octet-stream"},
                    {".smx", "audio/x-smd"},
                    {".smz", "audio/x-smd"},
                    {".snd", "audio/basic"},
                    {".snippet", "application/xml"},
                    {".snp", "application/octet-stream"},
                    {".sol", "text/plain"},
                    {".sor", "text/plain"},
                    {".spc", "application/x-pkcs7-certificates"},
                    {".spl", "application/futuresplash"},
                    {".src", "application/x-wais-source"},
                    {".srf", "text/plain"},
                    {".SSISDeploymentManifest", "text/xml"},
                    {".ssm", "application/streamingmedia"},
                    {".sst", "application/vnd.ms-pki.certstore"},
                    {".stl", "application/vnd.ms-pki.stl"},
                    {".sv4cpio", "application/x-sv4cpio"},
                    {".sv4crc", "application/x-sv4crc"},
                    {".svc", "application/xml"},
                    {".swf", "application/x-shockwave-flash"},
                    {".t", "application/x-troff"},
                    {".tar", "application/x-tar"},
                    {".tcl", "application/x-tcl"},
                    {".testrunconfig", "application/xml"},
                    {".testsettings", "application/xml"},
                    {".tex", "application/x-tex"},
                    {".texi", "application/x-texinfo"},
                    {".texinfo", "application/x-texinfo"},
                    {".tgz", "application/x-compressed"},
                    {".thmx", "application/vnd.ms-officetheme"},
                    {".thn", "application/octet-stream"},
                    {".tif", "image/tiff"},
                    {".tiff", "image/tiff"},
                    {".tlh", "text/plain"},
                    {".tli", "text/plain"},
                    {".toc", "application/octet-stream"},
                    {".tr", "application/x-troff"},
                    {".trm", "application/x-msterminal"},
                    {".trx", "application/xml"},
                    {".ts", "video/vnd.dlna.mpeg-tts"},
                    {".tsv", "text/tab-separated-values"},
                    {".ttf", "application/octet-stream"},
                    {".tts", "video/vnd.dlna.mpeg-tts"},
                    {".txt", "text/plain"},
                    {".u32", "application/octet-stream"},
                    {".uls", "text/iuls"},
                    {".user", "text/plain"},
                    {".ustar", "application/x-ustar"},
                    {".vb", "text/plain"},
                    {".vbdproj", "text/plain"},
                    {".vbk", "video/mpeg"},
                    {".vbproj", "text/plain"},
                    {".vbs", "text/vbscript"},
                    {".vcf", "text/x-vcard"},
                    {".vcproj", "Application/xml"},
                    {".vcs", "text/plain"},
                    {".vcxproj", "Application/xml"},
                    {".vddproj", "text/plain"},
                    {".vdp", "text/plain"},
                    {".vdproj", "text/plain"},
                    {".vdx", "application/vnd.ms-visio.viewer"},
                    {".vml", "text/xml"},
                    {".vscontent", "application/xml"},
                    {".vsct", "text/xml"},
                    {".vsd", "application/vnd.visio"},
                    {".vsi", "application/ms-vsi"},
                    {".vsix", "application/vsix"},
                    {".vsixlangpack", "text/xml"},
                    {".vsixmanifest", "text/xml"},
                    {".vsmdi", "application/xml"},
                    {".vspscc", "text/plain"},
                    {".vss", "application/vnd.visio"},
                    {".vsscc", "text/plain"},
                    {".vssettings", "text/xml"},
                    {".vssscc", "text/plain"},
                    {".vst", "application/vnd.visio"},
                    {".vstemplate", "text/xml"},
                    {".vsto", "application/x-ms-vsto"},
                    {".vsw", "application/vnd.visio"},
                    {".vsx", "application/vnd.visio"},
                    {".vtx", "application/vnd.visio"},
                    {".wav", "audio/wav"},
                    {".wave", "audio/wav"},
                    {".wax", "audio/x-ms-wax"},
                    {".wbk", "application/msword"},
                    {".wbmp", "image/vnd.wap.wbmp"},
                    {".wcm", "application/vnd.ms-works"},
                    {".wdb", "application/vnd.ms-works"},
                    {".wdp", "image/vnd.ms-photo"},
                    {".webarchive", "application/x-safari-webarchive"},
                    {".webtest", "application/xml"},
                    {".wiq", "application/xml"},
                    {".wiz", "application/msword"},
                    {".wks", "application/vnd.ms-works"},
                    {".WLMP", "application/wlmoviemaker"},
                    {".wlpginstall", "application/x-wlpg-detect"},
                    {".wlpginstall3", "application/x-wlpg3-detect"},
                    {".wm", "video/x-ms-wm"},
                    {".wma", "audio/x-ms-wma"},
                    {".wmd", "application/x-ms-wmd"},
                    {".wmf", "application/x-msmetafile"},
                    {".wml", "text/vnd.wap.wml"},
                    {".wmlc", "application/vnd.wap.wmlc"},
                    {".wmls", "text/vnd.wap.wmlscript"},
                    {".wmlsc", "application/vnd.wap.wmlscriptc"},
                    {".wmp", "video/x-ms-wmp"},
                    {".wmv", "video/x-ms-wmv"},
                    {".wmx", "video/x-ms-wmx"},
                    {".wmz", "application/x-ms-wmz"},
                    {".wpl", "application/vnd.ms-wpl"},
                    {".wps", "application/vnd.ms-works"},
                    {".wri", "application/x-mswrite"},
                    {".wrl", "x-world/x-vrml"},
                    {".wrz", "x-world/x-vrml"},
                    {".wsc", "text/scriptlet"},
                    {".wsdl", "text/xml"},
                    {".wvx", "video/x-ms-wvx"},
                    {".x", "application/directx"},
                    {".xaf", "x-world/x-vrml"},
                    {".xaml", "application/xaml+xml"},
                    {".xap", "application/x-silverlight-app"},
                    {".xbap", "application/x-ms-xbap"},
                    {".xbm", "image/x-xbitmap"},
                    {".xdr", "text/plain"},
                    {".xht", "application/xhtml+xml"},
                    {".xhtml", "application/xhtml+xml"},
                    {".xla", "application/vnd.ms-excel"},
                    {".xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
                    {".xlc", "application/vnd.ms-excel"},
                    {".xld", "application/vnd.ms-excel"},
                    {".xlk", "application/vnd.ms-excel"},
                    {".xll", "application/vnd.ms-excel"},
                    {".xlm", "application/vnd.ms-excel"},
                    {".xls", "application/vnd.ms-excel"},
                    {".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
                    {".xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12"},
                    {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                    {".xlt", "application/vnd.ms-excel"},
                    {".xltm", "application/vnd.ms-excel.template.macroEnabled.12"},
                    {".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
                    {".xlw", "application/vnd.ms-excel"},
                    {".xml", "text/xml"},
                    {".xmta", "application/xml"},
                    {".xof", "x-world/x-vrml"},
                    {".XOML", "text/plain"},
                    {".xpm", "image/x-xpixmap"},
                    {".xps", "application/vnd.ms-xpsdocument"},
                    {".xrm-ms", "text/xml"},
                    {".xsc", "application/xml"},
                    {".xsd", "text/xml"},
                    {".xsf", "text/xml"},
                    {".xsl", "text/xml"},
                    {".xslt", "text/xml"},
                    {".xsn", "application/octet-stream"},
                    {".xss", "application/xml"},
                    {".xtp", "application/octet-stream"},
                    {".xwd", "image/x-xwindowdump"},
                    {".z", "application/x-compress"},
                    {".zip", "application/x-zip-compressed"},

                    #endregion
                };


        public static int Size;

        public static int IsImage;

        public static int CoddingType;

        private static string codding;


        //public static QrCodes()
        //{
        //    Size = 150;
        //    IsImage = 0;
        //    CoddingType = 0;
        //}

        public static string GetCode(string text)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetMail(string email)
        {
            return GetMail(email, "", "");
        }

        public static string GetMail(string email, string subjectMail)
        {
            return GetMail(email, subjectMail, "");
        }

        public static string GetMail(string email, string subjectMail, string bodyMessage)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string str = string.Concat(new string[]
            {
                "MATMSG:TO:",
                email,
                ";SUB:",
                subjectMail,
                ";BODY:",
                bodyMessage,
                ";"
            });
            string text = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    email = text + HttpUtility.UrlEncode(str) + "&choe=" + codding;
                    break;
                case 1:
                    email = string.Concat(new string[]
                    {
                    "<img src='",
                    text,
                    HttpUtility.UrlEncode(str),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return email;
        }

        public static string GetGeo(string latitude, string longitude)
        {
            return GetGeo(latitude, longitude, "");
        }

        public static string GetGeo(string latitude, string longitude, string altitude)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = "geo:" + latitude.ToString() + "," + longitude.ToString();
            if (!string.IsNullOrEmpty(altitude))
            {
                text = text + "," + altitude;
            }
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetSms(long phoneNumber)
        {
            return GetSms(phoneNumber, "");
        }

        public static string GetSms(long phoneNumber, string smsMessage)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = "smsto:+" + phoneNumber.ToString() + ":" + smsMessage;
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetMms(long phoneNumber)
        {
            return GetMms(phoneNumber, "");
        }

        public static string GetMms(long phoneNumber, string mmsMessage)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = "mmsto:+" + phoneNumber.ToString() + ":" + mmsMessage;
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetPhone(long phoneNumber)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = "tel:+" + phoneNumber.ToString();
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetBookmark(string url, string titleUrl)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = string.Concat(new string[]
            {
                "MEBKM:TITLE:",
                titleUrl,
                ";URL:",
                url,
                ";"
            });
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string GetContact(string name, long phone, string url, string emailContact, string adresContact, string note)
        {
            switch (CoddingType)
            {
                case 0:
                    codding = "UTF-8";
                    break;
                case 1:
                    codding = "Shift_JIS";
                    break;
                case 2:
                    codding = "ISO-8859-1";
                    break;
            }
            string text = string.Concat(new string[]
            {
                "MECARD:N:",
                name,
                ";TEL:+",
                phone.ToString(),
                ";URL:",
                url,
                ";EMAIL:",
                emailContact,
                ";ADR:",
                adresContact,
                ";NOTE:",
                note,
                ";"
            });
            string text2 = string.Concat(new string[]
            {
                "http://chart.apis.google.com/chart?chs=",
                Size.ToString(),
                "x",
                Size.ToString(),
                "&cht=qr&chl="
            });
            switch (IsImage)
            {
                case 0:
                    text = text2 + HttpUtility.UrlEncode(text) + "&choe=" + codding;
                    break;
                case 1:
                    text = string.Concat(new string[]
                    {
                    "<img src='",
                    text2,
                    HttpUtility.UrlEncode(text),
                    "&choe=",
                    codding,
                    "'/>"
                    });
                    break;
            }
            return text;
        }

        public static string NullIfEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) ? null : s;
        }
        public static string NullIfWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : s;
        }


        public static bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
        }
        
        public static bool IsBase64String2(string base64)
        {
            base64 = base64.Trim();
            return (base64.Length % 4 == 0) && Regex.IsMatch(base64, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        public static string GetFileExtension(string base64String)
        {
            var data = base64String.Substring(0, 5);

            switch (data.ToUpper())
            {
                case "IVBOR":
                    return "png";
                case "/9J/4":
                    return "jpg";
                case "AAAAF":
                    return "mp4";
                case "JVBER":
                    return "pdf";
                case "AAABA":
                    return "ico";
                case "UMFYI":
                    return "rar";
                case "E1XYD":
                    return "rtf";
                case "U1PKC":
                    return "txt";
                case "MQOWM":
                case "77U/M":
                    return "srt";
                default:
                    return string.Empty;
            }
        }


    }
}
