using System.Security.Cryptography;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class SHA1
    {
        public static void CalculateHash(string plainTextFilePath, string hashOutputFilePath)
        {
            using (var sha = new SHA1CryptoServiceProvider())
            {
                var hash = sha.ComputeHash(FileOperations.ReadFromBinaryFile(plainTextFilePath));
                FileOperations.WriteToTextFile(hashOutputFilePath, Converter.ByteArrayToString(hash));
            }
        }
    }
}