using System;
using System.Linq;

//Problem 12.* Randomize the Numbers 1…N

//    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

//Examples:
//n 	randomized numbers 1…n
//3 	2 1 3
//10 	3 4 8 2 6 7 9 1 10 5

namespace _12RandomizeNums
{
    class RandomizeNums
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer n:\n");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n > 1))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }
            Random rand = new System.Random();
            nums = Enumerable.Range(1, n).OrderBy(r => rand.Next()).ToArray();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}
