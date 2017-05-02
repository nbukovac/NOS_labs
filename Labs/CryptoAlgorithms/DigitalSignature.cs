using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CryptoAlgorithms.Helpers;
using RSA = CryptoAlgorithms.Algorithms.RSA;

namespace CryptoAlgorithms
{
    public class DigitalSignature
    {

        public static void CreateSignature(string plainTextFilePath, int keySize, string privateKeyFilePath,
            string outputFilePath)
        {
            var messageBytes = FileOperations.ReadFromBinaryFile(plainTextFilePath);
            var signature = RSA.SignData(messageBytes, keySize, privateKeyFilePath, new SHA1CryptoServiceProvider());

            var message = Converter.ByteArrayToString(messageBytes);
            var hashText = Converter.ByteArrayToString(signature);

            var digitalSignature = "Signature:" + Environment.NewLine + hashText + Environment.NewLine +
                                   Environment.NewLine + "Message:" + Environment.NewLine + message;

            FileOperations.WriteToTextFile(outputFilePath, digitalSignature);
        }

        public static void CreateEnvelopeSignature(string envelopeTextFilePath, int keySize, string privateKeyFilePath,
            string outputFilePath)
        {
            var message = FileOperations.ReadFromTextFile(envelopeTextFilePath);
            var messageBytes = FileOperations.ReadFromBinaryFile(envelopeTextFilePath);
            var signature = RSA.SignData(messageBytes, keySize, privateKeyFilePath, new SHA1CryptoServiceProvider());

            var hashText = Converter.ByteArrayToString(signature);

            var digitalSignature = "Signature:" + Environment.NewLine + hashText + Environment.NewLine +
                                   Environment.NewLine + "Message:" + Environment.NewLine + message;

            FileOperations.WriteToTextFile(outputFilePath, digitalSignature);
        }

        public static bool VerifyEnvelopeSignature(string signatureFilePath, int keySize, string publicKeyFilePath)
        {
            var signatureText = FileOperations.ReadFromTextFile(signatureFilePath);
            var signatureTextSplit = signatureText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            var signature = Converter.HexStringToBytes(signatureTextSplit[1]);
            var message = Encoding.ASCII.GetBytes(signatureTextSplit[3] + Environment.NewLine + signatureTextSplit[4] 
                + Environment.NewLine + Environment.NewLine +
                signatureTextSplit[5] + Environment.NewLine + signatureTextSplit[6]);

            return RSA.VerifyData(message, keySize, publicKeyFilePath, new SHA1CryptoServiceProvider(), signature);
        }

        public static bool VerifySignature(string signatureFilePath, int keySize, string publicKeyFilePath)
        {
            var signatureText = FileOperations.ReadFromTextFile(signatureFilePath);
            var signatureTextSplit = signatureText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            var signature = Converter.HexStringToBytes(signatureTextSplit[1]);
            var message = Converter.HexStringToBytes(signatureTextSplit[3]);

            return RSA.VerifyData(message, keySize, publicKeyFilePath, new SHA1CryptoServiceProvider(), signature);
        }

    }
}
