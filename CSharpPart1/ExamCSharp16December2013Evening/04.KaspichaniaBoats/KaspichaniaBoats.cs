using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4
{
    class KaspichaniaBoats
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            Console.WriteLine(new String('.', n) + '*' + new String('.', n));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new String('.', n - (i + 1)) + 
                    '*' +
                    new String('.', i) +
                    '*' +
                    new String('.', i) +
                    '*' +
                    new String('.', n - (i + 1)));
            }
            Console.WriteLine(new String('*', width));
            for (int i = 0; i < ((width - n) / 2) - 1; i++)
            {
                Console.WriteLine(new String('.', i + 1) +
                    '*' +
                    new String('.', (width - (3 + (i + 1) * 2)) / 2) +
                    '*' +
                    new String('.', (width - (3 + (i + 1) * 2)) / 2) +
                    '*' +
                    new String('.', i + 1));
            }
            Console.WriteLine(new String('.', ((width - n) / 2)) +
                new String('*', n) +
                new String('.', ((width - n) / 2)));
        }
    }
}
