using System;

//Problem 1. Decimal to binary

//    Write a program to convert decimal numbers to their binary representation.


namespace _01DecimalToBinary
{
    public class DecimalToBinary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input integer number:");
            long number = long.Parse(Console.ReadLine());
            string binary = "";
            while (number > 0)
            {
                binary += number % 2;
                number = number / 2;
            }
            Console.WriteLine("The binary representation is:");
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }
}
