using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatchMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            var men = new string[n];
            var women = new string[n];
            var count = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine() + ' ');

                if (Console.ReadLine()[0] == 'm')
                {
                    Console.ReadLine();
                    men[count] = sb.Append( Console.ReadLine()).ToString();
                    count++;
                }
                else
                {
                    Console.ReadLine();
                    women[Array.IndexOf(women, null)] = sb.Append(Console.ReadLine()).ToString();
                }

                sb.Clear();
            }

            sb = null;
            Array.Resize(ref women, n - count);
            Array.Resize(ref men, count);


            var bestCommonInterests = 0;
            int commonInterests = 0;
            string bestMan = string.Empty;
            string bestWoman = string.Empty;

            var man = new string[0];
            var woman = new string[0];
            for (int i = 0; i < men.Length; i++)
            {
                for (int j = 0; j < women.Length; j++)
                {
                    man = men[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    woman = women[j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    commonInterests = man.Intersect(woman).Count();
                    if (commonInterests > bestCommonInterests || (commonInterests == bestCommonInterests && string.Compare(man[i], bestMan, false) < 0))
                    {
                        bestCommonInterests = commonInterests;
                        bestMan = man[0];
                        bestWoman = woman[0];
                    }

                }
            }

            if (bestCommonInterests <= 1)
            {
                Console.WriteLine("{0} and {1} have {2} common interest!", bestMan, bestWoman, bestCommonInterests);

                return;
            }

            Console.WriteLine("{0} and {1} have {2} common interests!", bestMan, bestWoman, bestCommonInterests);
        }
    }
}
