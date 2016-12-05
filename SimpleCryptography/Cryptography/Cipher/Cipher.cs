using System.Security.Cryptography;

namespace SimpleCryptography.Cryptography.Cipher
{
    public abstract class Cipher
    {
        internal CipherMode Mode
        {
            get { return CipherMode.CBC; }
        }

        internal PaddingMode Padding
        {
            get { return PaddingMode.PKCS7; }
        }

        internal CryptoStreamMode Writer
        {
            get { return CryptoStreamMode.Write; }
        }

        internal CryptoStreamMode Reader
        {
            get { return CryptoStreamMode.Read; }
        }

        internal RijndaelManaged GenerateSymmetricKey(int blockSize)
        {
            var symmetricKey = new RijndaelManaged();
            symmetricKey.BlockSize = blockSize;
            symmetricKey.Mode = Mode;
            symmetricKey.Padding = Padding;

            return symmetricKey;
        }

    }
}
