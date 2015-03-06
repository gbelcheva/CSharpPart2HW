using System;
using System.Linq;

//Problem 5. Sort by string length

//    You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


namespace _05SortByStringLength
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input strings on a single line, separated with a space:");
            string[] input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sortStrings(input);
            Console.WriteLine("Sorted strings:");
            Console.WriteLine(String.Join(" ", input));

        }

        static void sortStrings(string[] input)
        {
            var sorted = from s in input
                         orderby s.Length ascending
                         select s;
            int i = 0;
            foreach (var sort in sorted)
            {
                input[i] = sort;
                i++;
            }
 
        }
    }
}
