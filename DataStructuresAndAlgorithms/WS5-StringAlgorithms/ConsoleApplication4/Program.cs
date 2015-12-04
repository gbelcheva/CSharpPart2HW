using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            var len = pattern.Length;

            var failLinks = new int[pattern.Length + 1];

            failLinks[0] = -1;
            failLinks[1] = 0;

            for (int i = 1; i < len; i++)
            {
                int j = failLinks[i];
                while (j >= 0 && pattern[i] != pattern[j])
                {
                    j = failLinks[j];
                }

                failLinks[i + 1] = j + 1;
            }

            var matches = new List<int>();
            var found = 0;
            var alphabet = new int[26];
            for (int i = 0; i < len; i++)
            {
                if (pattern[i] > 'Z')
                {
                    while (found >= 0 && text[i] != pattern[found])
                    {
                        found = failLinks[found];
                    }

                    found++;

                    if (found == len)
                    {
                        matches.Add(i - len + 2);
                        //Console.WriteLine(i - (len -1));
                        found = failLinks[len];
                        break;
                    }
                }
                else
                {
                    if (text[i] > 'Z')
                    {
                        if (alphabet[pattern[i] - 'a'] == 0)
                        {
                            alphabet[pattern[i] - 'a'] = text[i] - 'a';
                        }
                        while (found >= 0 && text[i] != pattern[found])
                        {
                            found = failLinks[found];
                        }

                        found++;

                        if (found == len)
                        {
                            matches.Add(i - len + 2);
                            //Console.WriteLine(i - (len -1));
                            found = failLinks[len];
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(matches.Count);
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
