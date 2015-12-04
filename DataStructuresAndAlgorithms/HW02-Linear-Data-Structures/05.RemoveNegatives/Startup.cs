//Write a program that removes from given sequence all negative numbers.


namespace RemoveNegatives
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

            RemoveNegativeNumbers(inputSequence);
            Console.WriteLine(string.Join(" ", inputSequence));
        }

        static void RemoveNegativeNumbers(List<int> inputSequence)
        {
            for (int i = 0; i < inputSequence.Count; i++)
            {
                var currentNumber = inputSequence[i];
                if (currentNumber < 0)
                {
                    inputSequence.Remove(currentNumber);
                }
            }
        }
    }
}
