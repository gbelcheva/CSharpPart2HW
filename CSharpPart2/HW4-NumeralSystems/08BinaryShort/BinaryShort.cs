using System;

//Problem 8. Binary short

//    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


namespace _08BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input short integer:");
            short num = short.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation is:");
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
