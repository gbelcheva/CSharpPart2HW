using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CountNames
{
    class CountNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input names:");
            var allNames = Console.ReadLine().Split(' ');
            string[] names = allNames.Select(n => Convert.ToString(n)).ToArray();
            List<string> uniques = names.Distinct().OrderBy(d => d).ToList();
            int count = 0;
            for (int i = 0; i < uniques.Count; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if (uniques[i] == names[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} -> {1}", uniques[i], count);
                count = 0;
            }
        }
    }
}
