using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Hexadecimal to decimal

//    Write a program to convert hexadecimal numbers to their decimal representation.


namespace _04HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input HEX number:");
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
            Console.WriteLine("The decimal representation is:");
            Console.WriteLine(numDec);
        }
    }
}
