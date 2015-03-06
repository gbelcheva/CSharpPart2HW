using System;
using System.Collections.Generic;
using System.Linq;

//Problem 4. Binary search

//    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


namespace _04BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array with elements on a single line, separated with a space:");
            string[] input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Input element k to search:");
            int k = int.Parse(Console.ReadLine());
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
            int[] nums = new int[list.Count];
            nums = list.ToArray();
            bool kFound = false;
            int index = 0;
            while (!kFound)
            {
                index = Array.BinarySearch(nums, k);
                if (index > 0)
                {
                    kFound = true;
                }
                k--;
            }
            Console.WriteLine("Largest number <= k is:\n{0}", nums[index]);

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

    }
}
