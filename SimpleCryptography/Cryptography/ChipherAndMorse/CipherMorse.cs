using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morse = MorseCode.communication.MorseCode;
using MorseCode.protocol;

namespace SimpleCryptography.Cryptography.ChipherAndMorse
{
    public sealed class CipherMorse
    {
        public CipherMorse()
        {

        }

        public StringCipher Cipher()
        {
            return new StringCipher();
        }

        public Morse MorseCode()
        {
            return new Morse(new AmericanMorse());
        }
    }
}
