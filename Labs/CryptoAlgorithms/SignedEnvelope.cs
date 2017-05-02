using System;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms
{
    public class SignedEnvelope
    {
        public static void CreateSignedEnvelope(string plainTextFile, int keySize, string receiverPublicKeyFilePath,
            string senderPrivateKeyFilePath, string outputFilePath)
        {
            var tmpEnvelopeFilePath = Environment.CurrentDirectory + @"\Files\tmp\envelope_tmp.txt";

            DigitalEnvelope.CreateEnvelope(plainTextFile, keySize, receiverPublicKeyFilePath,
                tmpEnvelopeFilePath);

            DigitalSignature.CreateEnvelopeSignature(tmpEnvelopeFilePath, keySize, senderPrivateKeyFilePath,
                outputFilePath);
        }

        public static bool OpenSignedEnvelope(string signedEnvelopeFilePath, int keySize,
            string receiverPrivateKeyFilePath, string senderPublicKeyFilePath, string outputFilePath)
        {
            var verified = DigitalSignature.VerifyEnvelopeSignature(signedEnvelopeFilePath, keySize,
                senderPublicKeyFilePath);

            var file = FileOperations.ReadFromTextFile(signedEnvelopeFilePath);
            var fileSplit = file.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var keyBytes = Converter.HexStringToBytes(fileSplit[4]);
            var messageBytes = Converter.HexStringToBytes(fileSplit[6]);

            DigitalEnvelope.ReadEnvelope(keyBytes, messageBytes, keySize, receiverPrivateKeyFilePath, outputFilePath);

            return verified;
        }
    }
}