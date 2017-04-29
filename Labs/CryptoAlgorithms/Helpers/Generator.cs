using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            using (var writer = new StreamWriter(keyFilePath))
            {
                writer.Write(Converter.ByteArrayToString(bytes));
            }
        }


        public static void GenerateAesInitializationVector(string ivFilePath)
        {
            var bytes = new byte[AesIVBytes];
            var random = new Random();

            random.NextBytes(bytes);

            using (var writer = new StreamWriter(ivFilePath))
            {
                writer.Write(Converter.ByteArrayToString(bytes));
            }
        }

    }
}
