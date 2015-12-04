//Write a program that reads a sequence of integers(List<int>) 
//    ending with an empty line and sorts them in an increasing order.

namespace SortIncreasing
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input sequence:");
            var inputSequence = new List<int>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == string.Empty)
                {
                    break;
                }

                int inputNumber = Int32.Parse(inputLine);
                inputSequence.Add(inputNumber);
            }

            inputSequence.Sort();
            Console.WriteLine(string.Join(" ", inputSequence));
        }
    }
}
