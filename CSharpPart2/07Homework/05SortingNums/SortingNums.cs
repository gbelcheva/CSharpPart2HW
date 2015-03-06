using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SortingNums
{
    class SortingNums
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer n and n numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(0, n).ToArray();
            for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());
            int[] sorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                int smallerNumsCount = 0;
                int equalNumsCount = 0;
                for (int j = 0; j < n; j++)
                {
                    smallerNumsCount = numbers[i] > numbers[j] ? smallerNumsCount = smallerNumsCount + 1 : smallerNumsCount;
                    equalNumsCount = numbers[i] == numbers[j] ? equalNumsCount = equalNumsCount + 1 : equalNumsCount;
                }
                for (int j = smallerNumsCount; j < smallerNumsCount + equalNumsCount; j++)
                {
                    sorted[j] = numbers[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
