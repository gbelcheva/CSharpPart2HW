using System;

//Problem 11. Format number

//    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//    Format the output aligned right in 15 symbols.


namespace _11FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine("\nNumber in decimal, hex, percentage and scientific notation:\n");
            Console.WriteLine("{0, 15:N}", num);
            Console.WriteLine("{0, 15:X}", (long)num);
            Console.WriteLine("{0, 15:P}", num);
            Console.WriteLine("{0, 15:E}", num);
        }
    }
}
