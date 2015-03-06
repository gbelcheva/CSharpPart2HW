using System;
using System.Linq;

//Problem 8. Maximal sum

//    Write a program that finds the sequence of maximal sum in given array.

//Example:
//input 	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

namespace _08MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line separated with spaces:");
InvalidInput:
            string[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!IsValidInput(array))
            {
                goto InvalidInput;
            }
            int[] nums = Array.ConvertAll(array, s => int.Parse(s));
            Console.WriteLine("Maximal sum:\n{0}", String.Join(" ", GetMaximalSumSequence(nums)));
        }

        static bool IsValidInput(string[] input)
        {
            bool isValid = true;
            int tempInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out tempInt))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    isValid = false;
                }
            }
            return isValid;
        }
        static int[] GetMaximalSumSequence(int[] nums)
        {
            int maxSumCurrent = 0;
            int maxSum = nums[0];
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                maxSumCurrent += nums[i];
                if (maxSumCurrent <= 0)
                {
                    maxSumCurrent = 0;
                    maxSum = nums[i + 1];
                    startIndex = i + 1;

                }
                else if (maxSumCurrent > maxSum)
                {
                    maxSum = maxSumCurrent;
                    endIndex = i;
                }
            }
            int[] maximalSum = new int[endIndex - startIndex + 1];
            for (int i = 0; i < maximalSum.Length; i++)
            {
                maximalSum[i] = nums[startIndex + i];
            }
            return maximalSum;
        }
    }
}
