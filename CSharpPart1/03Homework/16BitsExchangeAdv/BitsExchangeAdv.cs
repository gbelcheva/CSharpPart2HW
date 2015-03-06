using System;
using System.Text.RegularExpressions;

//Problem 16.** Bit Exchange (Advanced)

//    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//    The first and the second sequence of bits may not overlap.

//Examples:
//n 	p 	q 	k 	binary representation of n 	binary result 	result
//1140867093 	3 	24 	3 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//4294901775 	24 	3 	3 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//2369124121 	2 	22 	10 	10001101 00110101 11110111 00011001 	01110001 10110101 11111000 11010001 	1907751121
//987654321 	2 	8 	11 	00111010 11011110 01101000 10110001 	- 	overlapping
//123456789 	26 	0 	7 	00000111 01011011 11001101 00010101 	- 	out of range
//33333333333 	-1 	0 	33 	00000111 11000010 11010010 01001101 01010101 	- 	out of range

namespace _16BitsExchangeAdv
{
    class BitsExchangeAdv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 32-bit unigned integer n, position p, position q, displacement k:");
            long nLong; //long type in case int is out of range and we still need the number for binary representation
            int p;
            int q;
            uint k;
            //check if input numbers are correct 
            while (!(long.TryParse(Console.ReadLine(), out nLong) && 
                     int.TryParse(Console.ReadLine(), out p) &&
                     int.TryParse(Console.ReadLine(), out q) &&
                     uint.TryParse(Console.ReadLine(), out k)))
            {
                Console.WriteLine("Invalid numbers, try again:");
            }
            //if number is too long or short for UInt32, give binary representation and "out of range" message
            if (! ((nLong > (long)(UInt32.MinValue)) &&
                  (nLong < (long)(UInt32.MaxValue))))
            {
                string binaryN1 = Convert.ToString((long)nLong, 2); //convert integer to string
                int binaryLength = binaryN1.Length;
                binaryLength = binaryLength + (8 - binaryLength % 8); //calculate byte length
                binaryN1 = Regex.Replace(binaryN1.PadLeft(binaryLength, '0'), ".{8}", "$0 "); //pad binary with zeros and separate every 8th character
                Console.WriteLine("Binary representation of n:\n{0}", binaryN1);
                Console.WriteLine("Result:\nout of range");
                return;
            }
            uint n = (uint)nLong; //the number is indeed inside UInt32 range and we can safely cast it and continue
            string binaryN = Regex.Replace(Convert.ToString(n, 2).PadLeft(32, '0'), ".{8}", "$0 "); //convert integer to string and separate every 8th character
            Console.WriteLine("Binary representation of n:\n{0}", binaryN);
            if (p - q > 0) //make sure p < q
            {
                p = p + q;
                q = p - q;
                p = p - q;
            } 
            if ((p < 0) || (q + k - 1 > 31))
            {
                Console.WriteLine("Result:\nout of range");
                return;
            }
            else if (p + k - 1 > q)
            {
                Console.WriteLine("Result:\noverlapping");
                return;
            }
            uint mask = 0;
            for (int i = 0; i < k; i++)
            {
                mask = mask + (uint)Math.Pow(2, i);
            }
            uint small = n & (mask << p);  //take bits {p, p+1, …, p+k-1}
            uint large = n & (mask << q); //take bits {q, q+1, …, q+k-1}
            uint result = n ^ (small | large); //prepare number by cleaning the bits to be replaced
            result = result | (large >> (q - p)) | (small << (q - p)); //replace bits
            string binaryResult = Regex.Replace(Convert.ToString(result, 2).PadLeft(32, '0'), ".{8}", "$0 "); //convert integer to string and separate every 8th character
            Console.WriteLine("Binary result:\n{0}", binaryResult); 
            Console.WriteLine("Result:\n{0}", result);
        }
    }
}
