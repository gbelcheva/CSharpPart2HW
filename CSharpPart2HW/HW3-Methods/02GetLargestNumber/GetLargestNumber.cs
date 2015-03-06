using System;

//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input three integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(GetMax(a, b), c);
            Console.WriteLine("The largest integer is:\n{0}", max);
        }

        private static int GetMax(int a, int b)
        {
            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                return a;
            }
            return a;
        }
    }
}
