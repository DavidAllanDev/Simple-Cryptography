using System;
using System.Collections.Generic;
using SimpleCryptography.PrimitiveCipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTest_SimpleCryptography.PrimitiveCipher
{
    [TestClass]
    public class Rot13Test
    {
        [TestMethod]
        public void canRotTo13()
        {
            var rot13 = new Rot13();
            var text = "David";
            var rot = rot13.Transform(text);

            Assert.AreNotEqual(text, rot);
        }

        [TestMethod]
        public void canRotTo13AndRecoverValue()
        {
            var rot13 = new Rot13();
            var text = "David";
            var rot = rot13.Transform(text);
            var originalText = rot13.Transform(rot);

            Assert.AreEqual(text, originalText);
        }
    }
}
