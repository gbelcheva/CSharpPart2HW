using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Election
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var parties = new List<int>();

            for (int i = 0; i < n; i++)
            {
                parties.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(GetSubsetSums(parties, k));

        }

        private static BigInteger GetSubsetSums(List<int> parties, int k)
        {
            var sums = new BigInteger[parties.Sum() + 1];
            sums[0] = 1;
            var maxSum = 0;

            for (int i = 0; i < maxSum; i++)
            {
                var num = parties[i];
                for (int j = parties.Sum(); j >= 0; j--)
                {
                    if (sums[j] > 0)
                    {
                        sums[j + num] += sums[j];
                        maxSum = Math.Max(j + num, maxSum);
                    }
                }
            }

            BigInteger coalitions = 0;
            for (int i = k; i < sums.Length; i++)
            {
                coalitions += sums[i];
            }

            return coalitions;
        }
    }
}
