using System;
using System.Linq;
using System.Text;
using SimpleCryptography.Cryptography.Cipher;

namespace SimpleCryptography.Cryptography
{
    public class StringCipher : Cryptogram, IStringCipher
    {
        private string _defaultpassPhrase = "-";

        public StringCipher(string DefaultpassPhrase = "-")
        {
            _defaultpassPhrase = DefaultpassPhrase == null ? _defaultpassPhrase : DefaultpassPhrase;
        }

        public string Encrypt(string plainText, string passPhrase = null, int keysize = 128)
        {
            passPhrase = passPhrase == null ? _defaultpassPhrase : passPhrase;

            ValidateInputTex(plainText);

            var saltStringBytes = GenerateRandomBits();
            var ivStringBytes = GenerateRandomBits();
            var plainTextBytes = Encoding.UTF8.GetBytes(FixedPassword + plainText);
            var encryptor = new CipherEncriptor();

            return encryptor.Encrypt(passPhrase, keysize, saltStringBytes, ivStringBytes, plainTextBytes, CalculateSize(keysize), Iterations);
        }

        public string Decrypt(string cipherText, string passPhrase = null, int keysize = 128)
        {

            passPhrase = passPhrase == null ? _defaultpassPhrase : passPhrase;

            ValidateInputTex(cipherText);

            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(CalculateSize(keysize)).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(CalculateSize(keysize)).Take(CalculateSize(keysize)).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((CalculateSize(keysize)) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((CalculateSize(keysize)) * 2)).ToArray();
            var decriptor = new CipherDecriptor();

            return decriptor.Decrypt(passPhrase, keysize, saltStringBytes, ivStringBytes, cipherTextBytes, CalculateSize(keysize), Iterations).Replace(FixedPassword, "");
        }
    }
}
