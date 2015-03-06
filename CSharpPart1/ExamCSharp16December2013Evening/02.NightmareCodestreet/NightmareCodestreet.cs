using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class NightmareCodestreet
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            int counter = 0;
            for (int i = 1; i < number.Length; i += 2)
            {
                if (Char.IsDigit(number[i]))
                {
                    sum = sum + (number[i] - '0');
                    counter++;
                }
                    
            }
            Console.WriteLine("{0} {1}", counter, sum);

        }
    }
}
