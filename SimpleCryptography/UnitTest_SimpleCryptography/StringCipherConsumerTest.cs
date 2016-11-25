using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCryptographyConsole;

namespace UnitTest_SimpleCryptography
{
    public class StringCipherConsumerTest
    {
        [TestMethod]
        public void canConsumerClassEncrypt()
        {
            string key = "Allan";

            StringCipherConsumer cipher = new StringCipherConsumer(key);

            string value = "David";

            string encryptedString = cipher.Encrypt(value);

            Assert.AreNotEqual(value, encryptedString);
        }

        [TestMethod]
        public void canConsumerClassDecrypt()
        {
            string key = "Allan";

            StringCipherConsumer cipher = new StringCipherConsumer(key);

            string value = "David";

            string encryptedString = cipher.Encrypt(value);

            string decryptedString = cipher.Decrypt(encryptedString);

            Assert.AreEqual(value, decryptedString);
        }
    }
}
