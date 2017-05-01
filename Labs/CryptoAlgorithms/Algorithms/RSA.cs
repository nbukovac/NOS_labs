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
                encrypted = rsa.Encrypt(bytes, true);
            }

            FileOperations.WriteToBinaryFile(outputFilePath, encrypted);
        }

    }

}
