using System;

//Problem 14. Decimal to Binary Number

//    Using loops write a program that converts an integer number to its binary representation.
//    The input is entered as long. The output should be a variable of type string.
//    Do not use the built-in .NET functionality.

//Examples:
//decimal 	binary
//0 	0
//3 	11
//43691 	1010101010101011
//236476736 	1110000110000101100101000000

namespace _14DecToBin
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            long numDec;
            while (!(long.TryParse(Console.ReadLine(), out numDec)))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            string numBinary = "";
            byte remainder;
            while (!(numDec == 0))
            {
                remainder = (byte)(numDec % 2);
                numBinary = numBinary + remainder.ToString();
                numDec = numDec / 2;
            }
            char[] binaryChars = numBinary.ToCharArray();
            Array.Reverse(binaryChars);
            numBinary = new string(binaryChars);
            Console.WriteLine("Binary:\n{0}", numBinary);
        }
    }
}
