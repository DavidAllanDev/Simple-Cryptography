using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCryptography.Cryptography;

namespace UnitTest_SimpleCryptography
{
    [TestClass]
    public class StringCipherTest
    {
        [TestMethod]
        public void isCapableToEncrypt()
        {
            StringCipher cipher = new StringCipher();

            string value = "David";
            string key = "Allan";

            string encryptedString = cipher.Encrypt(value, key);

            Assert.AreNotEqual(value, encryptedString);
        }

        [TestMethod]
        public void isCapableToDecrypt()
        {
            StringCipher cipher = new StringCipher();

            string value = "David";
            string key = "Allan";

            string encryptedString = cipher.Encrypt(value, key);

            string decryptedString = cipher.Decrypt(encryptedString, key);

            Assert.AreEqual(value, decryptedString);
        }
    }
}
