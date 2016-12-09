using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SimpleCryptography.Hashes.MD5
{
    public class MD5
    {
        public MD5CryptoServiceProvider Hasher()
        {
            return new MD5CryptoServiceProvider();
        }

        public byte[] PrepareStringToComputeHash(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public string GetStringHash(byte[] computedBytes)
        {
            return convertStringArray(ConvertBytesToString(computedBytes));
        }

        private static string[] ConvertBytesToString(byte[] computedBytes)
        {
            return computedBytes.Select(aByte => aByte.ToString("x2")).ToArray();
        }

        private string convertStringArray(string[] stringArray)
        {
            return string.Concat(stringArray);
        }
    }
}
