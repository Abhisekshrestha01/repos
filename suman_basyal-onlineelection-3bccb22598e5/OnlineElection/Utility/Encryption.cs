using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace OnlineElection.Utility
{


   
    




    public static class Encryption
    {
        private static string hash = "f0xle@rn";
        public static string Encrypt(string text)
        {

            string strmsg = string.Empty;
            byte[] encode = new byte[text.Length];
            encode = Encoding.UTF8.GetBytes(text);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;




            //string encryptedText = string.Empty;
            //byte [] data = UTF8Encoding.UTF8.GetBytes(text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{

            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        encryptedText = Convert.ToBase64String(results, 0, results.Length);

            //    }


            //}
            //return encryptedText;
        }

        public static string Decrypt(string text)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(text);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;




            //string decryptedText = string.Empty;
            //byte[] data= Convert.FromBase64String(text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{

            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() {
            //        Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        decryptedText = UTF8Encoding.UTF8.GetString(results);
            //    }
            //}
            //return decryptedText;
        }
    }
}