using System;

//Problem 16. Decimal to Hexadecimal Number

//    Using loops write a program that converts an integer number to its hexadecimal representation.
//    The input is entered as long. The output should be a variable of type string.
//    Do not use the built-in .NET functionality.

//Examples:
//decimal 	hexadecimal
//254 	FE
//6883 	1AE3
//338583669684 	4ED528CBB4

namespace _16DecToHex
{
    class DecToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            long numDec = long.Parse(Console.ReadLine());
            string numHex = "";
            while (!(numDec == 0))
            {
                byte remainder = (byte)(numDec % 16);
                char remainderChar;
                switch (remainder)
                {
                    case 10: remainderChar = 'A'; break;
                    case 11: remainderChar = 'B'; break;
                    case 12: remainderChar = 'C'; break;
                    case 13: remainderChar = 'D'; break;
                    case 14: remainderChar = 'E'; break;
                    case 15: remainderChar = 'F'; break;
                    case 16: remainderChar = 'G'; break;
                    default: remainderChar = Convert.ToChar(Convert.ToString(remainder));
                        break;
                }
                numHex = numHex + remainderChar;
                numDec = numDec / 16;
            }
            char[] hexChars = numHex.ToCharArray();
            Array.Reverse(hexChars);
            numHex = new string(hexChars);
            Console.WriteLine(numHex);
        }
    }
}
