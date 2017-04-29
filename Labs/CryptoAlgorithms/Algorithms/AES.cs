using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class AES
    {

        public static void Encrypt(string plainTextFilePath, string keyFilePath, string ivFilePath, 
            string outputFilePath)
        {
            var key = GetKeyFromFile(keyFilePath);
            var iv = GetIVFromFile(ivFilePath);
            byte[] encrypted;

            using (var aes = Aes.Create())
            {
                aes.IV = Converter.HexStringToBytes(iv);
                aes.Key = Converter.HexStringToBytes(key);

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(GetFileText(plainTextFilePath));
                        }
                    }

                    encrypted = memoryStream.ToArray();
                }
            }

            using (var writer = new BinaryWriter(new FileStream(outputFilePath, FileMode.Create)))
            {
                writer.Write(encrypted);
            }
        }

        private static string GetFileText(string filePath)
        {
            var text = "";

            using (var reader = new StreamReader(filePath))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        private static byte[] GetByteArrayFromFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public static void Decrypt(string cipherTextFilePath, string keyFilePath, string ivFilePath,
            string outputFilePath)
        {
            var key = GetKeyFromFile(keyFilePath);
            var iv = GetIVFromFile(ivFilePath);
            string plainText;

            using (var aes = Aes.Create())
            {
                aes.IV = Converter.HexStringToBytes(iv);
                aes.Key = Converter.HexStringToBytes(key);

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream(GetByteArrayFromFile(cipherTextFilePath)))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(cryptoStream))
                        {
                            plainText = reader.ReadToEnd();
                        }
                    }
                }
            }

            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(plainText);
            }
        }

        private static string GetIVFromFile(string ivFilePath)
        {
            string iv;
            using (var reader = new StreamReader(ivFilePath))
            {
                iv = reader.ReadLine().Trim();
            }
            return iv;
        }

        private static string GetKeyFromFile(string keyFilePath)
        {
            string key;
            using (var reader = new StreamReader(keyFilePath))
            {
                key = reader.ReadLine().Trim();
            }
            return key;
        }
    }
}
