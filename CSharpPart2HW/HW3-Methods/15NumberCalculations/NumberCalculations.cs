using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

namespace _15NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Type myType1 = Type.GetType("System.Int32");
            //myType1 numbers = Convert.ChangeType(input, myType1);
            short[] numbers = input.Select(x => short.Parse(x)).ToArray();
            Console.WriteLine("Available calculations: Min Max Avg Sum Prod\nChoose calculations to perform (single line separated with spaces):");
            string[] calcs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ReturnCalculations(numbers, calcs);
        }

        static void ReturnCalculations<T>(T[] nums, params string[] list)
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
        static T CalcMin<T>(T[] nums)
        {
            T min = nums[0];
            foreach (var num in nums)
            {
                if (Comparer<T>.Default.Compare(num, min) < 0)
                {
                    min = num;
                }
            }
            return min;
        }

        static T CalcMax<T>(T[] nums)
        {
            T max = nums[0];
            foreach (var num in nums)
            {
                if (Comparer<T>.Default.Compare(num, max) > 0)
                {
                    max = num;
                }
            }
            return max;
        }
        static double CalcAvg<T>(T[] nums)
        {
            double sum = 0;
            foreach (var num in nums)
            {
                sum += Convert.ToDouble(num);
            }
            double average = sum / nums.Length;
            return average;
        }
        static BigInteger CalcSum<T>(T[] nums)
        {
            BigInteger sum = 0;
            foreach (var num in nums)
            {
                sum += (BigInteger)Convert.ToDouble(num);
            }
            return sum;
        }
        static BigInteger CalcProd<T>(T[] nums)
        {
            BigInteger prod = 1;
            foreach (var num in nums)
            {
                prod *= (BigInteger)Convert.ToDouble(num);
            }
            return prod;
        }

    }
}
