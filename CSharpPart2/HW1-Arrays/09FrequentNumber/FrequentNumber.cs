using System;
using System.Collections.Generic;

//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

//Example:
//input 	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

namespace _09FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line separated with spaces:");
InvalidInput:
            string[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> nums = new List<int>();
            int tempInt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(array[i], out tempInt))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    goto InvalidInput;
                }
                nums.Add(int.Parse(array[i]));
            }
            Console.WriteLine("Most frequent number:\n{0} times)",String.Join(" (", GetMostFrequentNum(nums)));
        }

        static int[] GetMostFrequentNum(List<int> nums)
        {
            int mostFrequentNum = nums[0];
            int mostFrequentCount = 0;
            while (nums.Count > 0)
            {
                int curCount = 1;
                for (int j = 1; j < nums.Count; j++)
                {
                    if (nums[0] == nums[j])
                    {
                        curCount++;
                        nums.RemoveAt(j);
                        j--;
                    }
                    if (curCount > mostFrequentCount)
                    {
                        mostFrequentCount = curCount;
                        mostFrequentNum = nums[0];
                    }
                }
                nums.RemoveAt(0);
            }
            int[] result = { mostFrequentNum, mostFrequentCount };
            return result;
        }
    }
}
