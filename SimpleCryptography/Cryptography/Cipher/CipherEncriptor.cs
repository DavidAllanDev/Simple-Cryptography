using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace SimpleCryptography.Cryptography.Cipher
{
    public class CipherEncriptor
    {
        public string Encrypt(string passPhrase, int keysize, byte[] saltStringBytes, byte[] ivStringBytes, byte[] plainTextBytes, int size, int iterations)
        {
            var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, iterations);
            var keyBytes = password.GetBytes(size);
            using (var symmetricKey = new RijndaelManaged())
            {
                symmetricKey.BlockSize = keysize;
                symmetricKey.Mode = CipherMode.CBC;
                symmetricKey.Padding = PaddingMode.PKCS7;
                using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                {
                    var memoryStream = new MemoryStream();

                    var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    var cipherTextBytes = saltStringBytes;
                    cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                    cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                    memoryStream.Close();

                    return Convert.ToBase64String(cipherTextBytes);
                }
            }
        }
    }
}
