using System;
using System.Collections.Generic;
using System.Linq;

//Problem 13.* Merge sort

//    Write a program that sorts an array of integers using the Merge sort algorithm.


namespace _13MergeSort
{
    class MergeSort
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
            List<int> list = Array.ConvertAll(input, str => int.Parse(str)).ToList();
            int n = list.Count;
            int m = 1;
            while (m < n)
            {
                int i = 0;
                while (i < n - m)
                {
                    Merge(list, i, n - 1, i + m);
                    i = i + 2 * m;
                }
                m = m * 2;
            }
            Console.WriteLine("Sorted array:\n{0}", String.Join(" ", list));
        }
        static void Merge(List<int> list, int left, int right, int middle)
        {
            //fitting elements of list2 between elements of list1
            int afterInsPos = left;
            int i = 0;
            for (int j = middle; j <= right; j++)
            {
                for (i = afterInsPos; i < middle; i++)
                {
                    if (list[j] < list[i])
                    {
                        list.Insert(i, list[j]);
                        list.RemoveAt(j + 1);
                        middle++;
                        break;
                    }
                }
                afterInsPos = i;
            }
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
