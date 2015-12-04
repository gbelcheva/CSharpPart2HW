using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Program
    {
        static void Main()
        {


            Console.ReadLine();
            var input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> officialRanking = new List<int>();
            for (int i = 0; i < input1.Length; i++)
            {
                officialRanking.Add(int.Parse(input1[i]));
            }
            var input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> ivanchoRanking = new List<int>();
            for (int i = 0; i < input1.Length; i++)
            {
                ivanchoRanking.Add(int.Parse(input2[i]));
            }


            long numberOfInversions = 0;

            for (int i = 0; i < ivanchoRanking.Count; i++)
            {
                var currentInversionsIndex = officialRanking.IndexOf(ivanchoRanking[i]);
                numberOfInversions += currentInversionsIndex;
                
                officialRanking.RemoveAt(currentInversionsIndex);
            }

            Console.WriteLine(numberOfInversions);
        }
    }
}
