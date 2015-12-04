using System;
using System.Collections.Generic;
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
            int[] officialRanking = Array
                .ConvertAll(
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s))
                .ToArray();
            int[] ivanchoRanking = Array
                .ConvertAll(
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s))
                .ToArray();

            Array.Sort(officialRanking, ivanchoRanking);

            //int numberOfInversions = 0;

            //for (int i = 0; i < ivanchoRanking.Count; i++)
            //{
            //    var currentInversionsIndex = officialRanking.IndexOf(ivanchoRanking[i]);
            //    numberOfInversions += currentInversionsIndex;
                
            //    officialRanking.RemoveAt(currentInversionsIndex);
            //}

            Console.WriteLine();
        }
    }
}
