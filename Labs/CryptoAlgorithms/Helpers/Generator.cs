using System;

namespace CryptoAlgorithms.Helpers
{
    public class Generator
    {
        private const int AesKeyBytes = 32;
        private const int AesIVBytes = 16;

        public static byte[] GenerateAesKey()
        {
            var bytes = new byte[AesKeyBytes];
            var random = new Random();

            random.NextBytes(bytes);

            return bytes;
        }

        public static void GenerateAesKey(string keyFilePath)
        {
            FileOperations.WriteToTextFile(keyFilePath, Converter.ByteArrayToString(GenerateAesKey()));
        }


        public static byte[] GenerateAesInitializationVector()
        {
            var bytes = new byte[AesIVBytes];
            var random = new Random();

            random.NextBytes(bytes);

            return bytes;
        }

        public static void GenerateAesInitializationVector(string ivFilePath)
        {
            FileOperations.WriteToTextFile(ivFilePath, 
                Converter.ByteArrayToString(GenerateAesInitializationVector()));
        }
    }
}