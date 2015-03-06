using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input letters:");
            var allLetters = Console.ReadLine().Split(' ');
            char[] letters = allLetters.Select(n => Convert.ToChar(n)).ToArray();
            List<char> uniques = letters.Distinct().OrderBy(d => d).ToList();
            int count = 0;
            for (int i = 0; i < uniques.Count; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (uniques[i] == letters[j])
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
