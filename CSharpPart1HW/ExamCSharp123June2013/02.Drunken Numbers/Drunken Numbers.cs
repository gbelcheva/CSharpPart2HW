using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            ulong M = 0;
            ulong V = 0;
            for (byte i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string number = "";
                for (int j = 0; j < input.Length; j++)
                {
                    if (Char.IsDigit(input[j]))
                    {
                        number = number + input[j];
                    }
                }
                number = number.TrimStart(new Char[] { '0' });
                if (number.Length % 2 != 0)
                {
                    for (int k = 0; k <= number.Length / 2; k++)
                    {
                        M = M + number[k] - '0';
                        V = V + number[k + number.Length / 2 ] - '0';
                    }
                }
                else
                {
                    for (int k = 0; k < number.Length / 2; k++)
                    {
                        M = M + number[k] - '0';
                        V = V + number[k + number.Length / 2] - '0';
                    }
                }
            }
            if (M == V)
            {
                Console.WriteLine("No {0}", M + V);
            }
            else if (M > V)
            {
                Console.WriteLine("M {0}", M - V);
            }
            else
            {
                Console.WriteLine("V {0}", V - M);
            }
        }
    }
}
