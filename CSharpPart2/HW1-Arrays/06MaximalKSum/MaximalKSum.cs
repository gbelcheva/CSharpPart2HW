using System;

//Problem 6. Maximal K sum

//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
//    Find in the array those K elements that have maximal sum.


namespace _06MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer n:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input for n. Try again:\n");
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array({0}): ", i);
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Incorrect array input. Try again.\narray({0}): ", i);
                }
            }
            Console.WriteLine("Input integer k:");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Incorrect input for k. Try again:\n");
            }
            Console.WriteLine("Max K sum = {0}", GetMaxSumElementsSubset(array, k));
        }

        static int GetMaxSumElementsSubset(int[] array, int subsetSize)
        {
            int biggest = array[0];
            int biggestIndex = 0;
            int sum = 0;
            for (int i = 0; i < subsetSize; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > biggest)
                    {
                        biggest = array[j];
                        biggestIndex = j;
                    }
                }
                array[biggestIndex] = array[i];
                array[i] = biggest;
                sum += biggest;
                biggest = int.MinValue;
            }
            return sum;
        }
    }
}
