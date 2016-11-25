namespace SimpleCryptography.Cryptography
{
    public interface IStringCipher
    {
        string Decrypt(string cipherText, string passPhrase, int keysize = 128);
        string Encrypt(string plainText, string passPhrase, int keysize = 128);
    }
}
