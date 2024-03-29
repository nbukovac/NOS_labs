﻿using System.Security.Cryptography;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class RSA
    {
        private static readonly bool OptimalPadding = true;

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
                encrypted = rsa.Encrypt(bytes, OptimalPadding);
            }

            FileOperations.WriteToBinaryFile(outputFilePath, encrypted);
        }

        public static byte[] Encrypt(byte[] plainBytes, int keySize, string publicKeyFilePath)
        {
            var publicKeyXml = FileOperations.ReadFromTextFile(publicKeyFilePath);
            byte[] encrypted;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(publicKeyXml);
                encrypted = rsa.Encrypt(plainBytes, OptimalPadding);
            }

            return encrypted;
        }

        public static byte[] Decrypt(byte[] cipherBytes, int keySize, string privateKeyFilePath)
        {
            var privateKeyXml = FileOperations.ReadFromTextFile(privateKeyFilePath);
            byte[] decrypted;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(privateKeyXml);
                decrypted = rsa.Decrypt(cipherBytes, OptimalPadding);
            }

            return decrypted;
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
                decrypted = rsa.Decrypt(bytes, OptimalPadding);
            }

            FileOperations.WriteToBinaryFile(outputFilePath, decrypted);
        }

        public static byte[] SignData(byte[] data, int keySize, string privateKeyFilePath, object hashAlgorithm)
        {
            byte[] signature;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(FileOperations.ReadFromTextFile(privateKeyFilePath));
                signature = rsa.SignData(data, hashAlgorithm);
            }

            return signature;
        }

        public static bool VerifyData(byte[] data, int keySize, string publicKeyFilePath, object hashAlgorithm,
            byte[] signature)
        {
            var verified = false;

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(FileOperations.ReadFromTextFile(publicKeyFilePath));
                verified = rsa.VerifyData(data, hashAlgorithm, signature);
            }

            return verified;
        }
    }
}