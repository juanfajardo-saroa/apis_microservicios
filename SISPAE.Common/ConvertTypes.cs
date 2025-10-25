using System.Text;


namespace SISPAE.Common
{
    public static class ConvertTypes
    {

        /// <summary>
        /// Converts to stringbase64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ToStringBase64(this string value)
        {
            if (value.IsBase64())
            {
                byte[] data = Convert.FromBase64String(value);
                return Encoding.ASCII.GetString(data);
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Determines whether this instance is base64.
        /// </summary>
        /// <param name="base64String">The base64 string.</param>
        /// <returns>
        ///   <c>true</c> if the specified base64 string is base64; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBase64(this string base64String)
        {
            if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
            {
                return false;
            }

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch { }

            return false;
        }

    }
}
