using System;
using System.Text;

//Problem 7. Encode/decode

//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.


namespace _07EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string text = Console.ReadLine();
            Console.WriteLine("Input cipher:");
            string key = Console.ReadLine();
            StringBuilder encodedString = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                encodedString.Append((char)(text[i] ^ key[i % 3]));
            }
            Console.WriteLine("Encoded string is:");
            Console.WriteLine(encodedString.ToString());
            StringBuilder decodedString = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                decodedString.Append((char)(encodedString[i] ^ key[i % 3]));
            }
            Console.WriteLine("Decoded string is:");
            Console.WriteLine(decodedString.ToString());
        }
    }
}
