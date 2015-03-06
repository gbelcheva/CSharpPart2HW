using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib({0}) = {1}", n, Fib(n));
        }
        static ulong Fib(int n)
        {
            ulong fibonacci1 = 0;
            ulong fibonacci2 = 1;
            ulong fibonacci3 = 0;
            for (int i = 0; i < n; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }
            return fibonacci3;
        }
    }
}
