using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Helpers
{
    public class Converter
    {

        public static byte[] HexStringToBytes(string hexString)
        {
            return Enumerable.Range(0, hexString.Length)
                .Where(x => x % 2 == 0)
                .Select(x => System.Convert.ToByte(hexString.Substring(x, 2), 16))
                .ToArray();
        }

        public static string ByteArrayToString(byte[] bytes)
        {
            var hex = BitConverter.ToString(bytes);
            return hex.Replace("-", "");
        }
    }
}
