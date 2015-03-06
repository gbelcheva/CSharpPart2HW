using System;
using System.Text.RegularExpressions;

//Problem 15.* Bits Exchange

//    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

//Examples:
//n 	binary representation of n 	binary result 	result
//1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
//4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//5351 	00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
//2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705

namespace _15BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            uint number;
            while (! uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number. Input a number between {0} and {1}:", UInt32.MinValue, UInt32.MaxValue);
            }
            uint small = number & (7 << 3);  //take bits 3, 4, 5 (7 in binary is 111)
            uint large = number & (7 << 24); //take bits 24, 25, 26
            uint result = number ^ (small | large); //prepare number by cleaning the bits to be replaced
            result = result | (large >> 21) | (small << 21); //replace bits
            string binaryN = Regex.Replace(Convert.ToString(number, 2).PadLeft(32, '0'), ".{8}", "$0 "); //convert integer to string and separate every 8th character
            string binaryResult = Regex.Replace(Convert.ToString(result, 2).PadLeft(32, '0'), ".{8}", "$0 "); //convert integer to string and separate every 8th character
            Console.WriteLine("Binary representation of n:\n{0}", binaryN);
            Console.WriteLine("Binary result:\n{0}", binaryResult); 
            Console.WriteLine("Result:\n{0}", result);
        }
    }
}
