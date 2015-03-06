using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main(string[] args)
        {

            long[] first3 = new long[3];
            for (int i = 0; i < 3; i++)
            {
                first3[i] = long.Parse(Console.ReadLine());
            }
            int lines = int.Parse(Console.ReadLine());
            int n = lines * (lines + 1) / 2;
            long[] tribonacci = new long[n];
            for (int i = 0; i < 3; i++)
            {
                tribonacci[i] = first3[i];
            }
            for (int i = 3; i < n; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
            int k = 0;
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j != i - 1)
                    {
                        Console.Write(tribonacci[k] + " ");
                    }
                    else
                    {
                        Console.WriteLine(tribonacci[k]);
                    }
                    k++;
                }
            }
        }
    }
}
