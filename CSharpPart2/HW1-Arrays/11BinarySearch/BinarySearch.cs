using System;
using System.Collections.Generic;
using System.Linq;

//Problem 11. Binary search

//    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array with elements on a single line, separated with a space:");
InvalidInput:
            string[] input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!IsValidInput(input))
            {
                goto InvalidInput;
            }
            int[] nums = Array.ConvertAll(input, str => int.Parse(str));
            Console.WriteLine("Input element to find:");
            int element;
            while (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("Incorrect input for s. Try again:");
            }
            int index = FindIndextInSortedArray(nums, element);
            if (index == -1)
            {
                Console.WriteLine("Element {0} is not found int this array.", element);
            }
            else
            {
                Console.WriteLine("Index of element {0} is:\n{1}", element, index);
            }

        }

        static int FindIndextInSortedArray(int[] nums, int element)
        {
            bool notFound = true;
            int foundIndex = -1;
            List<int> curArray = nums.ToList();
            List<int> curArrayIndexes = new List<int>();
            if (curArray.Count % 2 == 0)
            {
                if (element == curArray[curArray.Count - 1])
                {
                    notFound = false;
                    foundIndex = curArray.Count - 1;
                }
                else
                {
                    curArray.RemoveAt(curArray.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < curArray.Count; i++)
                {
                    curArrayIndexes.Add(i);
                }
            }
            while (notFound && curArray.Count > 0)
            {
                if (element == curArray[curArray.Count / 2])
                {
                    notFound = false;
                    foundIndex = curArrayIndexes[curArray.Count / 2];
                    break;
                }
                else if (element < curArray[curArray.Count / 2])
                {
                    curArray = curArray.GetRange(0, curArray.Count / 2);
                    curArrayIndexes = curArrayIndexes.GetRange(0, curArrayIndexes.Count / 2);
                }
                else
                {
                    curArray = curArray.GetRange(curArray.Count / 2 + 1, curArray.Count / 2);
                    curArrayIndexes = curArrayIndexes.GetRange(curArrayIndexes.Count / 2 + 1, curArrayIndexes.Count / 2);
                }
            }
                return foundIndex;
        }

        static bool IsValidInput(string[] input)
        {
            bool isValid = true;
            int tempInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out tempInt))
                {
                    Console.WriteLine("Invalid input array. Input new array:");
                    isValid = false;
                }
            }
            int[] nums = Array.ConvertAll(input, str => int.Parse(str));
            bool sorted = true;
            int counter = 0;
            int[] sortedArray = (int[])nums.Clone();
            Array.Sort(sortedArray);
            while (sorted && counter < nums.Length)
            {
                if (sortedArray[counter] != nums[counter])
                {
                    sorted = false;
                }
                counter++;
            }
            if (!sorted)
            {
                Console.WriteLine("Array is not sorted. Input new array:");
                isValid = false;
            }
            return isValid;
        }
    }
}
