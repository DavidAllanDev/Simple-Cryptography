using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace SimpleCryptography.Cryptography.Cipher
{
    public class CipherDecriptor : Cipher
    {
        public string Decrypt(string passPhrase, int keysize, byte[] saltStringBytes, byte[] ivStringBytes, byte[] cipherTextBytes, int size, int iterations)
        {
            var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, iterations);
            var keyBytes = password.GetBytes(size);

            var decryptor = GenerateSymmetricKey(keysize).CreateDecryptor(keyBytes, ivStringBytes);
            
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, Reader);

            var plainTextBytes = new byte[cipherTextBytes.Length];
            var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();

            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
