using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class SimpleCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input names separated with space:");
            var allNames = Console.ReadLine().Split(' ');
            string[] names = allNames.Select(n => Convert.ToString(n)).ToArray();
            Console.WriteLine("Input names to remove:");
            var allRemoveNames = Console.ReadLine().Split(' ');
            string[] removeNames = allRemoveNames.Select(n => Convert.ToString(n)).ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < removeNames.Length; j++)
                {
                    if (names[i] == removeNames[j])
                    {
                        names[i] = "";
                    }
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != "")
                {
                    Console.Write("{0} ", names[i]);
                }
            }
            Console.WriteLine();
        }
    }
}