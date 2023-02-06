using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class SHA256Encryptor
    {
        /// <summary>
        /// using SHA256 to hash a string input then return the correspond hash code
        /// </summary>
        /// <param name="stringToHash">Input string to be hashed</param>
        /// <returns>SHA256 hash code that correspond to the input string</returns>
        public static string encrypt(string stringToHash)
        {
            if (String.IsNullOrEmpty(stringToHash))
                return String.Empty;
            using (var sha256 = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(stringToHash);
                byte[] hashedCode = sha256.ComputeHash(textData);
                string hashedString = BitConverter.ToString(hashedCode).Replace("-", String.Empty);
                return hashedString.ToLower();
            }
        }
    }
}
