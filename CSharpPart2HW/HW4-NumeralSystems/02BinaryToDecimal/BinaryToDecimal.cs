using System;

//Problem 2. Binary to decimal

//    Write a program to convert binary numbers to their decimal representation.


namespace _02BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input binary number:");
            string binary = Console.ReadLine();
            long number = 0;
            int biPower = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
			{
                number += (binary[i] - 48) * biPower;
                biPower = biPower * 2;
			}
            Console.WriteLine("The decimal representation is:");
            Console.WriteLine(number);
        }
    }
}
