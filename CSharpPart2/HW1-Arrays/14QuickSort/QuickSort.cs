using System;
using System.Linq;

//Problem 14. Quick sort

//    Write a program that sorts an array of integers using the Quick sort algorithm.


namespace _14QuickSort
{
    class QuickSort
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
            Sorting(nums, 0, nums.Length - 1);
            Console.WriteLine("Sorted array is:\n{0}", String.Join(" ", nums));

        }

        static void Sorting(int[] nums, int lowIndex, int highIndex)
        {
            int k = lowIndex;
            int l = highIndex;
            int pivot = nums[(lowIndex + highIndex) / 2]; //take middle element as pivot
            
            while (k <= l)
            {
                //find numbers to exchange around pivot
                while (nums[k] < pivot)
                {
                    k++;
                }
                while (nums[l] > pivot)
                {
                    l--;
                }
                //exchange numbers
                if (k <= l)
                {
                    int holder = nums[k];
                    nums[k] = nums[l];
                    nums[l] = holder;
                    //nums[k] = nums[l] + nums[k];
                    //nums[l] = nums[k] - nums[l];
                    //nums[k] = nums[k] - nums[l];
                    k++;
                    l--;
                }
            }
            //do the same again for all numbers smaller than pivot and all numbers larger than pivot
            if (l > lowIndex)
            {
                Sorting(nums, lowIndex, l);
            }
            if (k < highIndex)
            {
                Sorting(nums, k, highIndex);
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
