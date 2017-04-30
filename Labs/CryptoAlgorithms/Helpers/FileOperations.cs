using System.IO;

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

        public static void WriteToTextFile(string filePath, string text)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.Write(text);
            }
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