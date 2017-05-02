using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            DigitalSignature.CreateSignature(tmpEnvelopeFilePath, keySize, senderPrivateKeyFilePath, outputFilePath);
        }

        public static bool OpenSignedEnvelope(string signedEnvelopeFilePath, int keySize,
            string receiverPrivateKeyFilePath, string senderPublicKeyFilePath, string outputFilePath)
        {
            var verified = DigitalSignature.VerifySignature(signedEnvelopeFilePath, keySize, senderPublicKeyFilePath);

            var file = FileOperations.ReadFromTextFile(signedEnvelopeFilePath);
            var fileSplit = file.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var envelopeHex = fileSplit[3];

            return verified;
        }

    }
}
