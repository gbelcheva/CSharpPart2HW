using System;

//Maximal increasing sequence

//    Write a program that finds the maximal increasing sequence in an array.

//Example:
//input 	result
//3, 2, 3, 4, 2, 2, 4 	2, 3, 4

namespace _05MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer array with elements on a single line, separated with a space:");
InvalidInput:
            string[] inputString = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!IsValidInput(inputString))
            {
                goto InvalidInput;
            }
            int[] inputNums = new int[inputString.Length];
            for (int i = 0; i < inputNums.Length; i++)
			{
                inputNums[i] = Convert.ToInt32(inputString[i]);
			 
			}
            Console.WriteLine("Max increasing sequence:\n{0}", GetLongestIncreasingSequence(inputNums));
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
        static string GetLongestIncreasingSequence(int[] inputNums)
        {
            string maxSequence = "";
            string curSequence = "";
            for (int i = 0; i < inputNums.Length - 1; i++)
            {
                curSequence = inputNums[i].ToString() + " ";
                while (inputNums[i] < inputNums[i + 1])
                {
                    curSequence = curSequence + inputNums[i + 1].ToString() + " ";
                    i++;
                    if (i == inputNums.Length - 1)
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
