﻿using Morse = MorseCode.communication.MorseCode;
using MorseCode.protocol;

namespace SimpleCryptography.Cryptography.ChipherAndMorse
{
    public sealed class CipherMorse : StringCipher
    {
        private Morse _morse;
        public CipherMorse(IMorseType type)
            :base("Morse")
        {
            _morse = new Morse(type);
        }

        public string Cipher(string morse)
        {
            return Encrypt(morse);
        }

        public string UnCipher(string cipherMorse)
        {
            return Decrypt(cipherMorse);
        }

        public string Morse(string message)
        {
            return _morse.Morse(message);
        }

        public string UnMorse(string morse)
        {
            return _morse.UnMorse(morse);
        }

        public string MorseCipher(string message)
        {
            return Encrypt(Morse(message));
        }

        public string UnMorseCipher(string morseCipherMessage)
        {
            return UnMorse(Decrypt(morseCipherMessage));
        }
    }
}
