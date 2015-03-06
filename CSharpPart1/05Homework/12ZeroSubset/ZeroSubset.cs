using System;
using System.Collections.Generic;
using System.Linq;

//Problem 12.* Zero Subset

//    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//    Assume that repeating the same subset several times is not a problem.

//Examples:
//numbers 	result
//3 -2 1 1 8 	-2 + 1 + 1 = 0
	
//3 1 -7 35 22 	no zero subset
	
//1 3 -4 -2 -1 	1 + -1 = 0
//    1 + 3 + -4 = 0
//    3 + -2 + -1 = 0
	
//1 1 1 -1 -1 	1 + -1 = 0
//    1 + 1 + -1 + -1 = 0
	
//0 0 0 0 0 	0 + 0 + 0 + 0 + 0 = 0

//Hint: you may check for zero each of the 32 subsets with 32 if statements.

namespace _12ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input five numbers: ");
            int[] numbers = Enumerable.Range(0, 5).ToArray();
            for (int i = 0; i < 5; i++) numbers[i] = int.Parse(Console.ReadLine());
            List<int> negatives = new List<int>();
            List<int> positives = new List<int>();
            SeparateNums(numbers, out positives, out negatives);
            int[] positivesSorted = new int[positives.Count];
            SortNums(positives, out positivesSorted);
            int[] negativesSorted = new int[negatives.Count];
            SortNums(negatives, out negativesSorted);
            Array.Reverse(negativesSorted);
            int sumNeg = 0;
            int sumPos = 0;
            string zeros = "";
            bool subsetExists = false;
            for (int i = 0; i < positivesSorted.Length; i++)
            {
                if (positivesSorted[i] == 0)
                {
                    zeros = zeros + "0 + ";
                    Console.WriteLine("{0}\b\b= 0\n", zeros);
                    subsetExists = true;
                }
            }
            for (int i = 1; i < Math.Pow(2, positivesSorted.Length); i++)
            {
                string[] combinationsPos = new string[positivesSorted.Length];
                Combinations(positivesSorted, i, positivesSorted.Length, out combinationsPos, out sumPos);
                int counter = 0;
                while ((counter < negativesSorted.Length) && (sumPos + negativesSorted[counter] >= 0))
                {
                    counter++;
                }
                for (int j = 1; j < Math.Pow(2, counter); j++)
                {
                    string[] combinationsNeg = new string[counter];
                    Combinations(negativesSorted, j, counter, out combinationsNeg, out sumNeg);
                    if ((sumPos + sumNeg == 0))
                    {
                        for (int k = 0; k < combinationsNeg.Length; k++)
                        {
                            if (!(combinationsNeg[k] == null))
                            {
                                Console.Write("{0} + ", combinationsNeg[k]);
                            }
                        }
                        for (int k = 0; k < combinationsPos.Length; k++)
                        {
                            if (!(combinationsPos[k] == null))
                            {
                                Console.Write("{0} + ", combinationsPos[k]);
                            }
                        }
                        Console.WriteLine("\b\b= 0\n");
                        subsetExists = true;
                    }
                    sumNeg = 0;
                }
            }
            if (!subsetExists)
            {
                Console.WriteLine("no zero subset");
            }
        }


        static void SeparateNums(int[] nums, out List<int> positives, out List<int> negatives)
        {
            negatives = new List<int>();
            positives = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) negatives.Add(nums[i]);
                else positives.Add(nums[i]);
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

        static void Combinations(int[] nums, int counter, int length, out string[] combinations, out int sum)
        {
            combinations = new string[length];
            sum = 0;
            for (int i = 0; i < length; i++)
            {
                if ((counter & (1 << (length - i - 1))) != 0)
                {
                    combinations[i] = nums[i].ToString();
                }
            }
            for (int i = 0; i < combinations.Length; i++)
            {
                if (!(combinations[i] == null))
                {
                    sum = sum + Convert.ToInt32(combinations[i]);
                }
            }
        }
            
    }
}
