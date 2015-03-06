using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PalindromesMatrix
{
    class PalindromesMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of rows and columns: ");
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string[,] palindromesMatrix = new string[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    palindromesMatrix[i, j] = "" + (char)('a' + i) + (char)('a' + (j + i)) + (char)('a' + i);
                    Console.Write("{0} ", palindromesMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
