using System;

namespace CryptoAlgorithms.Helpers
{
    public class Generator
    {
        private const int AesKeyBytes = 32;
        private const int AesIVBytes = 16;

        public static void GenerateAesKey(string keyFilePath)
        {
            var bytes = new byte[AesKeyBytes];
            var random = new Random();

            random.NextBytes(bytes);

            FileOperations.WriteToTextFile(keyFilePath, Converter.ByteArrayToString(bytes));
        }


        public static void GenerateAesInitializationVector(string ivFilePath)
        {
            var bytes = new byte[AesIVBytes];
            var random = new Random();

            random.NextBytes(bytes);

            FileOperations.WriteToTextFile(ivFilePath, Converter.ByteArrayToString(bytes));
        }
    }
}