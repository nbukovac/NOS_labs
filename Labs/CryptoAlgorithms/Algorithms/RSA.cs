using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class RSA
    {

        private static bool _optimalPadding = true;

        public static void GenerateKeys(int keySize, string privateFilePath, string publicFilePath)
        {
            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                var publicKey = rsa.ToXmlString(false);
                var publicAndPrivateKeys = rsa.ToXmlString(true);


                FileOperations.WriteToTextFile(privateFilePath, publicAndPrivateKeys);
                FileOperations.WriteToTextFile(publicFilePath, publicKey);
            }
        }

        public static void Encrypt(string plainTextFilePath, int keySize, string publicKeyFilePath, 
            string outputFilePath)
        {
            var publicKeyXml = FileOperations.ReadFromTextFile(publicKeyFilePath);
            var bytes = FileOperations.ReadFromBinaryFile(plainTextFilePath);
            byte[] encrypted;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(publicKeyXml);
                encrypted = rsa.Encrypt(bytes, _optimalPadding);
            }

            FileOperations.WriteToBinaryFile(outputFilePath, encrypted);
        }

        public static void Decrypt(string cipherTextFilePath, int keySize, string privateKeyFilePath,
            string outputFilePath)
        {
            var privateKeyXml = FileOperations.ReadFromTextFile(privateKeyFilePath);
            var bytes = FileOperations.ReadFromBinaryFile(cipherTextFilePath);
            byte[] decrypted;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(privateKeyXml);
                decrypted = rsa.Decrypt(bytes, _optimalPadding);
            }

            FileOperations.WriteToBinaryFile(outputFilePath, decrypted);
        }

    }

}
