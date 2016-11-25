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

            Console.WriteLine("Now lets decrypt this:" + encryptedString);
            Console.ReadLine();

            Console.WriteLine("So the decrypted value is:" + cipher.Decrypt(encryptedString));
            Console.ReadLine();
        }
    }
}
