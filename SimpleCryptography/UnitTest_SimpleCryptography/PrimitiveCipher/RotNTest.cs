using SimpleCryptography.PrimitiveCipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_SimpleCryptography.PrimitiveCipher
{
    [TestClass]
    public class RotNTest
    {
        [TestMethod]
        public void canRotToN()
        {
            var N = 12;
            var rot13 = new RotN(N);
            var text = "David";
            var rot = rot13.Transform(text);

            Assert.AreNotEqual(text, rot);
        }

        [TestMethod]
        public void canRotToNAndRecoverValue()
        {
            var N = 15;
            var rot13 = new RotN(N);
            var text = "David";
            var rot = rot13.Transform(text);
            var originalText = rot13.Transform(rot);

            Assert.AreEqual(text, originalText);
        }
    }
}
