using System;
using System.Collections.Generic;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms.Algorithms
{
    public class CustomSHA1
    {
        private const int BlockSizeBytes = 64;
        private const int SizeBytes = 8;
        private const int ByteShift = 8;
        private const int BigArraySizeBytes = 80;
        private const int WordsInBlock = 16;

        private const uint Constant0 = 0x5A827999;
        private const uint Constant1 = 0x6ED9EBA1;
        private const uint Constant2 = 0x8F1BBCDC;
        private const uint Constant3 = 0xCA62C1D6;

        private const uint Hash0 = 0x67452301;
        private const uint Hash1 = 0xEFCDAB89;
        private const uint Hash2 = 0x98BADCFE;
        private const uint Hash3 = 0x10325476;
        private const uint Hash4 = 0xC3D2E1F0;

        // (B AND C) OR ((NOT B) AND D)
        private static readonly Func<uint, uint, uint, uint> F1Func = (b, c, d) => (b & c) | ((~b) & d);
        // B XOR C XOR D
        private static readonly Func<uint, uint, uint, uint> F2Func = (b, c, d) => b ^ c ^ d;
        // (B AND C) OR (B AND D) OR (C AND D)
        private static readonly Func<uint, uint, uint, uint> F3Func = (b, c, d) => (b & c) | (b & d) | (c & d);


        public static void CalculateHash(string plainTextFile, string hashOutputFilePath)
        {
            var paddedInput = PadInput(plainTextFile);
            var blocks = CreateBlocks(paddedInput);
            var hash = new[] {Hash0, Hash1, Hash2, Hash3, Hash4};

            GetHash(blocks, hash);

            var hashString = Converter.UIntArrayToString(hash);

            FileOperations.WriteToTextFile(hashOutputFilePath, hashString);
        }

        private static void GetHash(IEnumerable<uint[]> blocks, uint[] hash)
        {
            uint[] w = new uint[BigArraySizeBytes];

            foreach (var block in blocks)
            {
                for (var t = 0; t < WordsInBlock; t++)
                {
                    w[t] = block[t];
                }

                for (var t = WordsInBlock; t < 80; t++)
                {
                    w[t] = RotateLeft(1, w[t - 3] ^ w[t - 8] ^ w[t - 14] ^ w[t - 16]);
                }

                var A = hash[0];
                var B = hash[1];
                var C = hash[2];
                var D = hash[3];
                var E = hash[4];

                for (var i = 0; i < 80; i++)
                {
                    uint temp = 0;

                    if (i < 20)
                    {
                        temp = RotateLeft(5, A) + F1Func(B, C, D) + E + w[i] + Constant0;
                    }
                    else if (i < 40)
                    {
                        temp = RotateLeft(5, A) + F2Func(B, C, D) + E + w[i] + Constant1;
                    }
                    else if (i < 60)
                    {
                        temp = RotateLeft(5, A) + F3Func(B, C, D) + E + w[i] + Constant2;
                    }
                    else
                    {
                        temp = RotateLeft(5, A) + F2Func(B, C, D) + E + w[i] + Constant3;
                    }

                    E = D;
                    D = C;
                    C = RotateLeft(30, B);
                    B = A;
                    A = temp;
                }

                hash[0] += A;
                hash[1] += B;
                hash[2] += C;
                hash[3] += D;
                hash[4] += E;
            }
        }

        private static IEnumerable<uint[]> CreateBlocks(uint[] paddedInput)
        {
            var blocks = new List<uint[]>();
            var temp = new uint[WordsInBlock];

            for (var i = 0; i < paddedInput.Length; i++)
            {
                temp[i%WordsInBlock] = paddedInput[i];

                if (i%WordsInBlock == WordsInBlock - 1)
                {
                    blocks.Add(temp);
                    temp = new uint[WordsInBlock];
                }
            }

            return blocks;
        }

        private static uint RotateLeft(int bits, uint word)
        {
            return (word << bits) | (word >> (32 - bits));
        }


        private static uint[] PadInput(string filePath)
        {
            var paddedBytes = PadInputBytes(filePath);
            var paddedInput = new uint[paddedBytes.Length/4];

            for (var i = 0; i < paddedBytes.Length; i += 4)
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
            var bytesToPad = Convert.ToUInt32(BlockSizeBytes - inputBytes.Length%BlockSizeBytes);
            var paddedInput = new byte[inputBytes.Length + bytesToPad];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                paddedInput[i] = inputBytes[i];
            }

            paddedInput[inputBytes.Length] = 0x80;

            for (int i = 1; i < bytesToPad - 8; i++)
            {
                paddedInput[inputBytes.Length + i] = 0;
            }

            var converted = BitConverter.GetBytes((long)inputBytes.Length * SizeBytes);

            for (int i = converted.Length - 1; i >= 0; i--)
            {
                paddedInput[paddedInput.Length - i - 1] = converted[i];
            }

            return paddedInput;
        }

        private static byte GetByte(uint x, int n)
        {
            return (byte) ((x >> (8*n)) & 0xFF);
        }
    }
}