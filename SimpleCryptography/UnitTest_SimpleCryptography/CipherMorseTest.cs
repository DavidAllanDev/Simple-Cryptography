using MorseCode.protocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCryptography.Cryptography.ChipherAndMorse;

namespace UnitTest_SimpleCryptography
{
    [TestClass]
    public class CipherMorseTest
    {
        [TestMethod]
        public void canChipherAndMorse()
        {
            var cipherMorse = new CipherMorse(new AmericanMorse());

            string message = "DAVID";
            string morse = cipherMorse.Morse(message);
            string cipher = cipherMorse.Cipher(morse);
            string original = cipherMorse.UnMorse(cipherMorse.Decrypt(cipher));

            Assert.AreEqual(message, original);
        }
    }
}
