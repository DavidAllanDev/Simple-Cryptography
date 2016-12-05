using SimpleCryptography.Cryptography;

namespace SimpleCryptographyConsole
{
    public class StringCipherConsumer : StringCipher
    {
        private string _passPhrase;
        public StringCipherConsumer(string passPhrase = "DefaultPassPhrase")
            : base(passPhrase)
        {
            _passPhrase = passPhrase;
        }

        public string Encrypt(string plainText)
        {
            try
            {
                return base.Encrypt(plainText);
            }
            catch
            {
                return plainText;
            }
        }

        public string Decrypt(string cipherText)
        {
            try
            {
                return base.Decrypt(cipherText);
            }
            catch
            {
                return cipherText;
            }
        }

    }
}
