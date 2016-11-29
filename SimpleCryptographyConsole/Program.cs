using System;

namespace SimpleCryptographyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedString = ProcessEncrytedPart();
            ProcessDecryptesPart(encryptedString);
        }

        private static void ProcessDecryptesPart(string encryptedString)
        {
            var cipher = new StringCipherConsumer(getUserContent("Please enter a passphrase:"));

            ShowContent("Now lets decrypt this:" + encryptedString);

            ShowContent("So the decrypted value is:" + cipher.Decrypt(encryptedString));
        }

        private static string ProcessEncrytedPart()
        {
            var cipher = new StringCipherConsumer(getUserContent("Please enter a passphrase:"));
            string userText = getUserContent("Please enter your text:");

            var encryptedString = cipher.Encrypt(userText);
            ShowContent("your encrypted text is:" + encryptedString);

            return encryptedString;
        }

        private static string getUserContent(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static void ShowContent(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
