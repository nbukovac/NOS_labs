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
                        var bytes = FileOperations.ReadFromBinaryFile(plainTextFilePath);
                        cryptoStream.Write(bytes, 0, bytes.Length);
                    }

                    encrypted = memoryStream.ToArray();
                }
            }

            FileOperations.WriteToBinaryFile(outputFilePath, encrypted);
        }

        public static void Decrypt(string cipherTextFilePath, string keyFilePath, string ivFilePath,
            string outputFilePath)
        {
            var key = GetKeyFromFile(keyFilePath);
            var iv = GetIVFromFile(ivFilePath);
            byte[] decrypted;

            using (var aes = Aes.Create())
            {
                aes.IV = Converter.HexStringToBytes(iv);
                aes.Key = Converter.HexStringToBytes(key);

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                var encrypted = FileOperations.ReadFromBinaryFile(cipherTextFilePath);
                decrypted = new byte[encrypted.Length];

                using (var memoryStream = new MemoryStream(encrypted))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        cryptoStream.Read(decrypted, 0, encrypted.Length);
                    }
                }
            }

            FileOperations.WriteToBinaryFile(outputFilePath, decrypted);
        }

        private static string GetIVFromFile(string ivFilePath)
        {
            return FileOperations.ReadFromTextFile(ivFilePath);
        }

        private static string GetKeyFromFile(string keyFilePath)
        {
            return FileOperations.ReadFromTextFile(keyFilePath);
        }
    }
}
