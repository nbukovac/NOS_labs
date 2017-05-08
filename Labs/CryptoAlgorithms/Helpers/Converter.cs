using System;
using System.Linq;
using System.Text;

namespace CryptoAlgorithms.Helpers
{
    public class Converter
    {
        public static byte[] HexStringToBytes(string hexString)
        {
            return Enumerable.Range(0, hexString.Length)
                .Where(x => x%2 == 0)
                .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                .ToArray();
        }

        public static string ByteArrayToString(byte[] bytes)
        {
            var hex = BitConverter.ToString(bytes);
            return hex.Replace("-", "");
        }

        public static string UIntArrayToString(uint[] data)
        {
            var sb = new StringBuilder();

            foreach (var value in data)
            {
                var top = value >> 24;
                var midHigh = (value << 8) >> 24;
                var midLow = (value << 16) >> 24;
                var low = value & 0xFF;

                sb.Append(top.ToString("X2") + midHigh.ToString("X2") + midLow.ToString("X2") + low.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}