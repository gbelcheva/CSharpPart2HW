using System;
using System.Collections.Generic;
using System.Linq;

//Problem 10. Find sum in array

//    Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example:
//array 	S 	result
//4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5

namespace _10FindSumInArray
{
    class FindSumInArray
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
            int[] nums = Array.ConvertAll(array, str => int.Parse(str));
            Console.WriteLine("Input sum to check:");
            int sum;
            while (!int.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Incorrect input for s. Try again:\n");
            }
            
            if (!FindSumInInput(nums, sum))
            {
                Console.WriteLine("The sum {0} was not found in the given array.", sum);
            }

        }

        static bool FindSumInInput(int[] nums, int sum)
        {
            bool sumFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int curSum = nums[i];
                List<int> foundNums = new List<int>();
                foundNums.Add(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (curSum == sum)
                    {
                        Console.WriteLine("The sum {0} is found in:\n{1}", sum, String.Join(" ", foundNums));
                        sumFound = true;
                    }
                    curSum += nums[j];
                    foundNums.Add(nums[j]);
                    
                }
            }
            return sumFound;
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
    }
}
