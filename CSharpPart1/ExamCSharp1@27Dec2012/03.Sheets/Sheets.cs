using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2).PadLeft(11, '0');
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    Console.WriteLine("A" + i.ToString());
                }
            }
        }

    }
}
