using System;
using System.Linq;
using System.Numerics;

//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace _14IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (!IsValidIntegerSequence(input))
            {
                Console.WriteLine("Invalid integer sequence. Try again.");
                input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Available calculations: Min Max Avg Sum Prod\nChoose calculations to perform (single line separated with spaces):");
            string[] calcs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ReturnCalculations(numbers, calcs);
        }

        static void ReturnCalculations(int[] nums, params string[] list)
        {
            foreach (var param in list)
            {
                switch (param.ToLower())
                {
                    case "min": Console.WriteLine("Min: {0}", CalcMin(nums));
                        break;
                    case "max": Console.WriteLine("Max: {0}", CalcMax(nums)); 
                        break;
                    case "avg": Console.WriteLine("Average: {0}", CalcAvg(nums)); 
                        break;
                    case "sum": Console.WriteLine("Sum: {0}", CalcSum(nums)); 
                        break;
                    case "prod": Console.WriteLine("Product: {0}", CalcProd(nums)); 
                        break;
                    default:
                        break;
                }
            }
        }
        static int CalcMin(int[] nums)
        {
            int min = nums[0];
            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static int CalcMax(int[] nums)
        {
            int max = nums[0];
            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static float CalcAvg(int[] nums)
        {
            float sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            float average = sum / (float)nums.Length;
            return average;
        }
        static BigInteger CalcSum(int[] nums)
        {
            BigInteger sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static BigInteger CalcProd(int[] nums)
        {
            BigInteger prod = 1;
            foreach (var num in nums)
            {
                prod *= num;
            }
            return prod;
        }

        static bool IsValidIntegerSequence(string[] input)
        {
            bool isValid = true;
            int tempInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out tempInt))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
