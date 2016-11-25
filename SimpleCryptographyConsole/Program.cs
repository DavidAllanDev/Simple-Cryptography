using System;

namespace SimpleCryptographyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string passPhrase = getUserContent("Please enter a passphrase:");

            StringCipherConsumer cipher = new StringCipherConsumer(passPhrase);

            string userText = getUserContent("Please enter your text:");

            string encryptedString = cipher.Encrypt(userText);

            ShowContent("your encrypted text is:" + encryptedString);

            ShowContent("Now lets decrypt this:" + encryptedString);

            ShowContent("So the decrypted value is:" + cipher.Decrypt(encryptedString));
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
