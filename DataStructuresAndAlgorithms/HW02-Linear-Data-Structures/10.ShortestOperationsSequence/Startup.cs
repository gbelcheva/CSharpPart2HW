//We are given numbers N and M and the following operations:

//    N = N+1
//    N = N+2

//    N = N*2

//    Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
//    Hint: use a queue.
//    Example: N = 5, M = 16
//    Sequence: 5 → 7 → 8 → 16

namespace ShortestOperationsSequence
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input N:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input M:");
            int m = Int32.Parse(Console.ReadLine());

            var sequence = new Queue<int>();

            while (n <= m)
            {
                sequence.Enqueue(m);

                if (m / 2 >= n)
                {
                    m /= 2;
                }
                else if (m - 2 >= n)
                {
                    m -= 2;
                }
                else
                {
                    m -= 1;
                }
            }

            Console.WriteLine(string.Join(" -> ", sequence.Reverse()));
        }
    }
}
