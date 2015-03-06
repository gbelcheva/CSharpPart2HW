using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number list:");
            var allNumbers = Console.ReadLine().Split(' ');
            int[] numbers1 = allNumbers.Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine("Input second number list:");
            allNumbers = Console.ReadLine().Split(' ');
            int[] numbers2 = allNumbers.Select(n => Convert.ToInt32(n)).ToArray();
            List<int> all = new List<int>();
            for (int i = 0; i < numbers1.Length; i++)
            {
                all.Add(numbers1[i]);
            }
            for (int i = 0; i < numbers2.Length; i++)
            {
                all.Add(numbers2[i]);
            }
            all = all.Distinct().ToList();
            int[] allSorted = new int[all.Count];
            SortNums(all, out allSorted);
            for (int i = 0; i < allSorted.Length; i++)
            {
                Console.Write("{0} ", allSorted[i]);
            }
            Console.WriteLine();
        }
        static void SortNums(List<int> nums, out int[] sorted)
        {
            sorted = new int[nums.Count];
            for (int i = 0; i < nums.Count; i++)
            {
                int smallerNumsCount = 0;
                int equalNumsCount = 0;
                for (int j = 0; j < nums.Count; j++)
                {
                    smallerNumsCount = nums[i] > nums[j] ? smallerNumsCount = smallerNumsCount + 1 : smallerNumsCount;
                    equalNumsCount = nums[i] == nums[j] ? equalNumsCount = equalNumsCount + 1 : equalNumsCount;
                }
                for (int j = smallerNumsCount; j < smallerNumsCount + equalNumsCount; j++)
                {
                    sorted[j] = nums[i];
                }
            }
        }
    }
}
