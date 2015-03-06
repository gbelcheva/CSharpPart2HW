using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

namespace _1._10LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            int num = 2;
            int sign = -1;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(num);
                num = num + sign * (5 + i * 2);
                sign = sign * (-1);
            }
        }
    }
}
