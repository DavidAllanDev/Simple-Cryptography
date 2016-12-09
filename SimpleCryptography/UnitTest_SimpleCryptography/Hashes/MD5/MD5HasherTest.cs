using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCryptography.Hashes.MD5;

namespace UnitTest_SimpleCryptography.Hashes.MD5
{
    [TestClass]
    public class MD5HasherTest
    {
        [TestMethod]
        public void canGetMD5FromText()
        {
            MD5Hasher hasher = new MD5Hasher();
            string text = "Some text to hash in MD5 mode";

            string hash = hasher.HashText(text);

            Assert.IsTrue(hash != null);
            Assert.AreNotEqual(text, hash);
        }

        [TestMethod]
        public void canGetMD5HasFromFile()
        {
            MD5Hasher hasher = new MD5Hasher();
            string fileName = @"C:\Windows\notepad.exe";

            string hash = hasher.GetFileHash(fileName);

            Assert.IsTrue(hash != null);
        }
    }
}
