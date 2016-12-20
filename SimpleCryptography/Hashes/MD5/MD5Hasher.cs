using System.Linq;
using System.IO;

namespace SimpleCryptography.Hashes.MD5
{
    public class MD5Hasher : MD5
    {
        public string HashText(string text)
        {
            return GetStringHash(Hasher().ComputeHash(PrepareStringToComputeHash(text)));
        }

        public string GetFileHash(string fileName)
        {
            return GetStringHash(Hasher().ComputeHash(GetFileStream(fileName)));
        }

        private FileStream GetFileStream(string fileName)
        {
            return new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
        }
    }
}
