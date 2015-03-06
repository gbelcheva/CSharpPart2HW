using System;

//Problem 15. Hexadecimal to Decimal Number

//    Using loops write a program that converts a hexadecimal integer number to its decimal form.
//    The input is entered as string. The output should be a variable of type long.
//    Do not use the built-in .NET functionality.

//Examples:
//hexadecimal 	decimal
//FE 	254
//1AE3 	6883
//4ED528CBB4 	338583669684

namespace _15HexToDec
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input hex number:");
            string numHex = Console.ReadLine();
            numHex = numHex.ToUpper();
            char[] charHex = numHex.ToCharArray();
            Array.Reverse(charHex);
            byte[] hexValues = new byte[numHex.Length];
            for (int i = 0; i < charHex.Length; i++)
            {
                switch (charHex[i])
                {
                    case 'A': hexValues[i] = 10; break;
                    case 'B': hexValues[i] = 11; break;
                    case 'C': hexValues[i] = 12; break;
                    case 'D': hexValues[i] = 13; break;
                    case 'E': hexValues[i] = 14; break;
                    case 'F': hexValues[i] = 15; break;
                    case 'G': hexValues[i] = 16; break;
                    default: hexValues[i] = Convert.ToByte(charHex[i].ToString()); 
                        break;
                }
            }
            long numDec = 0;
            for (int i = 0; i < charHex.Length; i++)
            {
                numDec = numDec + (long)(hexValues[i] * Math.Pow(16, i));
            }
            Console.WriteLine("Decimal:\n{0}", numDec);
        }
    }
}
