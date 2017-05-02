using System.IO;
using System.Security.Cryptography;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class AES
    {
        public static void Encrypt(string plainTextFilePath, string keyFilePath, string ivFilePath,
            string outputFilePath)
        {
            var key = GetKeyFromFile(keyFilePath);
            var iv = GetIvFromFile(ivFilePath);
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

        public static byte[] Encrypt(byte[] key, byte[] iv, string plainTextFilePath)
        {
            byte[] encrypted;

            using (var aes = Aes.Create())
            {
                var encryptor = aes.CreateEncryptor(key, iv);

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

            return encrypted;
        }

        public static byte[] Decrypt(byte[] key, byte[] iv, byte[] cipherBytes)
        {
            byte[] decrypted;

            using (var aes = Aes.Create())
            {
                var decryptor = aes.CreateDecryptor(key, iv);
                decrypted = new byte[cipherBytes.Length];

                using (var memoryStream = new MemoryStream(cipherBytes))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        cryptoStream.Read(decrypted, 0, cipherBytes.Length);
                    }
                }
            }

            return decrypted;
        }

        public static void Decrypt(string cipherTextFilePath, string keyFilePath, string ivFilePath,
            string outputFilePath)
        {
            var key = GetKeyFromFile(keyFilePath);
            var iv = GetIvFromFile(ivFilePath);
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

        private static string GetIvFromFile(string ivFilePath)
        {
            return FileOperations.ReadFromTextFile(ivFilePath);
        }

        private static string GetKeyFromFile(string keyFilePath)
        {
            return FileOperations.ReadFromTextFile(keyFilePath);
        }
    }
}