using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class CustomSHA1
    {

        private const int BlockSizeBytes = 64;
        private const int ByteShift = 8;

        private const uint Constant0 = 0x5A827999;
        private const uint Constant1 = 0x6ED9EBA1;
        private const uint Constant2 = 0x8F1BBCDC;
        private const uint Constant3 = 0xCA62C1D6;

        private const uint Hash0 = 0x67452301;
        private const uint Hash1 = 0xEFCDAB89;
        private const uint Hash2 = 0x98BADCFE;
        private const uint Hash3 = 0x10325476;
        private const uint Hash4 = 0xC3D2E1F0;

        public static void CalculateHash(string plainTextFile, string hashOutputFilePath)
        {
            var paddedInput = PadInput(plainTextFile);
            var blocks = CreateBlocks(paddedInput);
        }

        private static IEnumerable<uint[]> CreateBlocks(uint[] paddedInput)
        {
            var blocks = new List<uint[]>();
            var temp = new uint[BlockSizeBytes];

            for (int i = 0; i < paddedInput.Length; i++)
            {
                temp[i%BlockSizeBytes] = paddedInput[i];

                if (i % BlockSizeBytes == BlockSizeBytes - 1)
                {
                    blocks.Add(temp);
                    temp = new uint[BlockSizeBytes];
                }
            }

            return blocks;
        }

        private static uint[] PadInput(string filePath)
        {
            var paddedBytes = PadInputBytes(filePath);
            uint[] paddedInput = new uint[paddedBytes.Length / 4];

            for (int i = 0; i < paddedBytes.Length; i += 4)
            {
                uint temp = 0;

                temp += paddedBytes[i];
                temp <<= ByteShift;

                temp += paddedBytes[i + 1];
                temp <<= ByteShift;

                temp += paddedBytes[i + 2];
                temp <<= ByteShift;

                temp += paddedBytes[i + 3];

                paddedInput[i/4] = temp;
            }

            return paddedInput;
        }

        private static byte[] PadInputBytes(string filePath)
        {
            var inputBytes = FileOperations.ReadFromBinaryFile(filePath);
            var bytesToPad = Convert.ToUInt32((BlockSizeBytes - inputBytes.Length%BlockSizeBytes)%BlockSizeBytes);
            byte[] paddedInput = new byte[inputBytes.Length + bytesToPad];

            if (bytesToPad == 0)
            {
                Array.Copy(inputBytes, paddedInput, inputBytes.Length);
            }
            else
            {
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    paddedInput[i] = inputBytes[i];
                }

                paddedInput[inputBytes.Length] = 0x80;

                for (int i = 1; i < bytesToPad - 2; i++)
                {
                    paddedInput[inputBytes.Length + i] = 0;
                }

                paddedInput[inputBytes.Length - 2] = GetByte((BlockSizeBytes - bytesToPad)*8, 1);
                paddedInput[inputBytes.Length - 1] = GetByte((BlockSizeBytes - bytesToPad)*8, 0);
            }

            return paddedInput;
        }

        private static byte GetByte(uint x, int n)
        {
            return (byte)((x >> 8 * n) & 0xFF);
        }

    }
}
