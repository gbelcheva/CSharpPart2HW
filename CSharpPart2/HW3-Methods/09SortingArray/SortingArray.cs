using System;
using System.Linq;

//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

namespace _09SortingArray
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (!IsValidIntegerSequence(input))
            {
                Console.WriteLine("Invalid integer sequence. Try again.");
                input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Input A for ascending and D for descending order:");
            string order = Console.ReadLine();
            while (order.ToLower() != "a" && order.ToLower() != "d")
            {
                Console.WriteLine("Wrong order keyword. Try again.");
                order = Console.ReadLine();
            }
            SortArr(numbers, order);
            Console.WriteLine(String.Join(" ", numbers));
        }

        static int[] GetMaxElement(int start, int[] array)
        {
            int[] maxElement = new int[2]; 
            maxElement[0] = array[start];
            maxElement[1] = start;
            for (int i = start + 1; i < array.Length; i++)
            {
                if (array[i] > maxElement[0])
                {
                    maxElement[0] = array[i];
                    maxElement[1] = i;
                }
            }
            return maxElement;
        }

        static void SortArr(int[] array, string order)
        {
            int tmp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int maxElement = GetMaxElement(i, array)[0];
                int index = GetMaxElement(i, array)[1];
                tmp = array[i];
                array[i] = maxElement;
                array[index] = tmp;

            }
            if (order.ToLower() == "a")
            {
                Array.Reverse(array);
            }
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
