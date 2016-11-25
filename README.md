# Simple-Cryptography
A Simple Cryptography project that uses the cipherMode to do it

This project is intended to be a demo of using cipher to encrypt and
decrypt strings by using a pass phrase

To open all projects in the solution, use the solution file located in "..\SimpleCryptography\SimpleCryptography.sln"
so you'll be able to see the projects:
SimpleCryptography  (witch has the cipher main features);
SimpleCryptographyConsole that uses the SimpleCryptography to create its own way to encrypt/decrypt;
and UnitTest_SimpleCryptography to test and to know how to cosume those projects above.

One cool thing you can see in this projects is:
when you go to SimpleCryptographyConsole project and look at StringCipherConsumer class,
you can see that it inherits from StringCipher(that is in SimpleCryptography project)
and has a clear uses of the inheritance control, defining a constructor that calls "base class" to pass through the default passphrase, instead of using "this" arg(the current class). (see it also in: base.Encrypt() and base.Decrypt())

Other cool thing is the use of abstract class on StringCipher that it inherits it from Cryptogram.
