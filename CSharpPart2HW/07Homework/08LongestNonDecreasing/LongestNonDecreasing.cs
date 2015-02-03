using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LongestNonDecreasing
{
    class LongestNonDecreasing
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input numbers separated with space:");
            var allNumbers = Console.ReadLine().Split(' ');
            int[] numbers = allNumbers.Select(n => Convert.ToInt32(n)).ToArray();
            List<int> subsequence = new List<int>();
            List<int> longestSubsequence = NonDecreasingSequence(0, numbers[0], numbers);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                subsequence = NonDecreasingSequence(i, numbers[i], numbers);
                longestSubsequence = (subsequence.Count > longestSubsequence.Count) ? subsequence : longestSubsequence;
            }
            for (int i = 0; i < longestSubsequence.Count; i++)
            {
                Console.WriteLine("{0} ", longestSubsequence[i]);
            }
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

        static List<int> NonDecreasingSequence(int counter, int number, int[] numbers)
        {
            List<int> subsequence = new List<int>();
            subsequence.Add(number);
            int nextNumber = numbers[counter];
            for (int j = counter + 1; j < numbers.Length; j++)
            {
                if (nextNumber <= numbers[j])
                {
                    subsequence.Add(numbers[j]);
                    nextNumber = numbers[j];
                }
            }
            return subsequence;
        }
    }
}
