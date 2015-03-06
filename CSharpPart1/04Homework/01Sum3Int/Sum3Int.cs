using System;
using System.Globalization;

//Problem 1. Sum of 3 Numbers

//    Write a program that reads 3 real numbers from the console and prints their sum.

//Examples:
//a 	b 	c 	sum
//3 	4 	11 	18
//-2 	0 	3 	1
//5.5 	4.5 	20.1 	30.1

namespace _01Sum3Int
{
    class Sum3Int
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input three integers:");
            float i1;
            float i2;
            float i3;
            while (!(float.TryParse(Console.ReadLine(), out i1) && 
                     float.TryParse(Console.ReadLine(), out i2) && 
                     float.TryParse(Console.ReadLine(), out i3)))
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
            float sum = i1 + i2 + i3;
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
