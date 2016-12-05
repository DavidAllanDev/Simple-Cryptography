using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace SimpleCryptography.Cryptography.Cipher
{
    public class CipherEncriptor : Cipher
    {
        public string Encrypt(string passPhrase, int keysize, byte[] saltStringBytes, byte[] ivStringBytes, byte[] plainTextBytes, int size, int iterations)
        {
            var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, iterations);
            var keyBytes = password.GetBytes(size);

            var encryptor = GenerateSymmetricKey(keysize).CreateEncryptor(keyBytes, ivStringBytes);
            var memoryStream = new MemoryStream();

            var cryptoStream = new CryptoStream(memoryStream, encryptor, Writer);

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
