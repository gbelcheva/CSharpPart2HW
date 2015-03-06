using System;

//Problem 13. Binary to Decimal Number

//    Using loops write a program that converts a binary integer number to its decimal form.
//    The input is entered as string. The output should be a variable of type long.
//    Do not use the built-in .NET functionality.

//Examples:
//binary 	decimal
//0 	0
//11 	3
//1010101010101011 	43691
//1110000110000101100101000000 	236476736

namespace _13BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input binary:");
            string numBinary = Console.ReadLine();
            //char[] numChars = numBinary.ToCharArray();
            //Array.Reverse(numChars);
            long numDecimal = 0;
            for (int i = 0; i < numBinary.Length; i++)
            {
                numDecimal = numDecimal << 1;
                numDecimal = numDecimal + (numBinary[i] == '1' ? 1 : 0);
                
            }
            Console.WriteLine("Decimal:\n{0}", numDecimal);
        }
    }
}
