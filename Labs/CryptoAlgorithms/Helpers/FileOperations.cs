using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Helpers
{
    public class FileOperations
    {

        public static string ReadFromTextFile(string filePath)
        {
            string text;

            using (var reader = new StreamReader(filePath))
            {
                text = reader.ReadToEnd().Trim();
            }

            return text;
        }

        public static byte[] ReadFromBinaryFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public static void WriteToBinaryFile(string filePath, byte[] bytes)
        {
            using (var writer = new BinaryWriter(new FileStream(filePath, FileMode.Create)))
            {
                writer.Write(bytes);
            }
        }

    }
}
