using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong r = 0;
            switch (b)
            {
                case 2: r = a % c;
                    break;
                case 4: r = a + c;
                    break;
                case 8: r = a * c;
                    break;
                default:
                    break;
            }
            ulong result = (r % 4 == 0) ? r / 4 : r % 4;
            Console.WriteLine("{0}\n{1}", result, r);
        }
    }
}
