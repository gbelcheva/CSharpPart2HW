//Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

//    Write a program to test whether the method works correctly.


namespace LongestSequenceEqualNumbers
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

            List<int> longestSequence = GetLongestSequence(inputSequence);
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        static List<int> GetLongestSequence(List<int> inputSequence)
        {
            List<int> longestSequence = new List<int>();
            List<int> currentSequence = new List<int>();
            while (inputSequence.Count > 0)
            {
                int currentElement = inputSequence[0];
                currentSequence.Add(currentElement);
                inputSequence.RemoveAt(0);

                for (int i = 0; i < inputSequence.Count; i++)
                {
                    var number = inputSequence[i];
                    if (number == currentElement)
                    {
                        currentSequence.Add(number);
                        inputSequence.Remove(number);
                    }
                }

                if (currentSequence.Count >= longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }

                currentSequence.Clear();
            }

            return longestSequence;
        }
    }
}
