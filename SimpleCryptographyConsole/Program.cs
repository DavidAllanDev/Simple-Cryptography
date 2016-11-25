using System;

namespace SimpleCryptographyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a passphrase:");
            string passPhrase = Console.ReadLine();

            StringCipherConsumer cipher = new StringCipherConsumer(passPhrase);

            Console.WriteLine("Please enter your text:");
            string userText = Console.ReadLine();

            string encryptedString = cipher.Encrypt(userText);
            Console.WriteLine("your encrypted text is:" +encryptedString);
            Console.ReadLine();

            Console.WriteLine("Now lets decrypt this:" + encryptedString);
            Console.ReadLine();

            Console.WriteLine("So the decrypted value is:" + cipher.Decrypt(encryptedString));
            Console.ReadLine();
        }
    }
}
