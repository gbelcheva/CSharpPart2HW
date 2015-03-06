using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace _1._06Sequence
{
    class Sequence
    {
        static void Main(string[] args)
        {
            int num = 2;
            int sign = -1;
            for (int i = 0; i < 9; i++)
            {
                Console.Write(num + ", ");
                num = num + sign * (5 + i * 2);
                sign = sign*(-1);
            }
            Console.WriteLine(num);
        }
    }
}
