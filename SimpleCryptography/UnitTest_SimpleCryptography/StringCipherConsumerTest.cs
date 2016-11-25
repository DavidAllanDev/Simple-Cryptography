using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCryptographyConsole;

namespace UnitTest_SimpleCryptography
{
    public class StringCipherConsumerTest
    {
        [TestMethod]
        public void canConsumerClassEncrypt()
        {
            StringCipherConsumer cipher = new StringCipherConsumer();

            string value = "David";
            string key = "Allan";

            string encryptedString = cipher.Encrypt(value, key);

            Assert.AreNotEqual(value, encryptedString);
        }

        [TestMethod]
        public void canConsumerClassDecrypt()
        {
            StringCipherConsumer cipher = new StringCipherConsumer();

            string value = "David";
            string key = "Allan";

            string encryptedString = cipher.Encrypt(value, key);

            string decryptedString = cipher.Decrypt(encryptedString, key);

            Assert.AreEqual(value, decryptedString);
        }
    }
}
