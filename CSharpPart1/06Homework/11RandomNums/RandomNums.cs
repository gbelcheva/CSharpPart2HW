using System;

//Problem 11. Random Numbers in Given Range

//    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

//Examples:
//n 	min 	max 	random numbers
//5 	0 	1 	1 0 0 1 1
//10 	10 	15 	12 14 12 15 10 12 14 13 13 11

//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.

namespace _11RandomNums
{
    class RandomNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers n, min, max:");
            int n;
            int min;
            int max;
            while (!(int.TryParse(Console.ReadLine(), out n) && 
                     int.TryParse(Console.ReadLine(), out min) &&
                     int.TryParse(Console.ReadLine(), out max) &&                
                     n > 0))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int random = r.Next(min, max + 1);
                Console.Write("{0} ", random);
            }
            Console.WriteLine();
        }
    }
}
