using System;

//Problem 4. Maximal sequence

//    Write a program that finds the maximal sequence of equal elements in an array.


namespace _04MaximalSequence
{
    class MaximalSequence
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
            Console.WriteLine("Max sequence of equal elements:\n{0}", GetMaxSequence(input));
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
        static string GetMaxSequence(string[] input)
        {
            string maxSequence = "";
            string curSequence = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                curSequence = input[i] + " ";
                while (input[i] == input[i + 1])
                {
                    curSequence = curSequence + input[i + 1] + " ";
                    i++;
                    if (i == input.Length - 1)
                    {
                        break;
                    }
                }
                if (curSequence.Length > maxSequence.Length)
                {
                    maxSequence = curSequence;
                }
            }
            return maxSequence.Remove(maxSequence.Length - 1);
        }
    }
}
