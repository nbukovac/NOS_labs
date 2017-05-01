using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoAlgorithms.Algorithms;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms
{
    public class DigitalEnvelope
    {

        public static void CreateEnvelope(string plainTextFilePath, int keySize, string publicKeyFilePath, 
            string outputFilePath)
        {
            var aesKey = Generator.GenerateAesKey();
            var aesIv = Generator.GenerateAesInitializationVector();
            var aesEncrypted = AES.Encrypt(aesKey, aesIv, plainTextFilePath);

            var rsaPlain = new byte[aesKey.Length + aesIv.Length];
            CreateRsaPlainText(aesKey, rsaPlain, aesIv);
            var keyEncrypted = RSA.Encrypt(rsaPlain, keySize, publicKeyFilePath);

            var envelope = "Key:" + Environment.NewLine + Converter.ByteArrayToString(keyEncrypted)
                           + Environment.NewLine + Environment.NewLine + "Message:" + Environment.NewLine +
                           Converter.ByteArrayToString(aesEncrypted);

            FileOperations.WriteToTextFile(outputFilePath, envelope);
        }

        public static void ReadEnvelope(string envelopeFilePath, int keySize, string privateKeyFilePath,
            string outputFilePath)
        {
            var envelope = FileOperations.ReadFromTextFile(envelopeFilePath);
            var envelopeSplit = envelope.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            var keyEncrypted = Converter.HexStringToBytes(envelopeSplit[1]);
            var messageEncrypted = Converter.HexStringToBytes(envelopeSplit[3]);

            var keyDecrypted = RSA.Decrypt(keyEncrypted, keySize, privateKeyFilePath);
            byte[] aesKey;
            byte[] aesIv;

            GetAesParameters(keyDecrypted, out aesKey, out aesIv);

            var decrypted = AES.Decrypt(aesKey, aesIv, messageEncrypted);

            FileOperations.WriteToBinaryFile(outputFilePath, decrypted);
        }

        private static void GetAesParameters(byte[] keyDecrypted, out byte[] key, out byte[] iv)
        {
            key = new byte[keyDecrypted.Length - 16];
            iv = new byte[16];

            for (int i = 0; i < keyDecrypted.Length - 16; i++)
            {
                key[i] = keyDecrypted[i];
            }

            for (int i = 0; i < 16; i++)
            {
                iv[i] = keyDecrypted[key.Length + i];
            }
        }

        private static void CreateRsaPlainText(byte[] aesKey, byte[] rsaPlain, byte[] aesIv)
        {
            for (int i = 0; i < aesKey.Length; i++)
            {
                rsaPlain[i] = aesKey[i];
            }

            for (int i = aesKey.Length; i < aesIv.Length; i++)
            {
                rsaPlain[i] = aesIv[i - aesKey.Length];
            }
        }
    }
}
