﻿using System.Security.Cryptography;
using System;

namespace SimpleCryptography.Cryptography
{
    abstract public class Cryptogram
    {
        internal const int BaseByteSize = 8;
        internal const int Iterations = 500;
        internal const string FixedPassword = "Put her some fixed password you want";

        internal byte[] GenerateRandomBits()
        {
            var randomBytes = new byte[CalculateSize()];
            var rngCryptoSerivce = new RNGCryptoServiceProvider();

            rngCryptoSerivce.GetBytes(randomBytes);

            return randomBytes;
        }

        internal int CalculateSize(int Keysize = 128)
        {
            return Keysize / BaseByteSize;
        }

        internal void ValidateInputTex(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("Is not a valid input text");
        }
    }
}
