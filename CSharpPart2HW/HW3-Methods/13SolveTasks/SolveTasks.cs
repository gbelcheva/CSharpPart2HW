using System;
using System.Linq;

//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace _13SolveTasks
{
    class SolveTasks
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a task to solve.\n> Input 1 for Reverse number digits\n> Input 2 for Calculate average of a sequence of integers\n> Input 3 for Solve linear equation");
            int choice = 0;
            while (choice != 1 && choice != 2 && choice != 3)
            {
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    break;
                }
                Console.WriteLine("Invalid choice. Try again.");
            }

            switch (choice)
            {
                case 1:
                                Console.WriteLine("Input number to reverse:");
                                char[] input1 = Console.ReadLine().ToCharArray();
                                while (input1[0] == '-' || !IsValidNumber(input1))
                                {
                                    Console.WriteLine("Invalid number. Try again.");
                                    input1 = Console.ReadLine().ToCharArray();
                                }
                                Console.WriteLine("The number with reversed digits is:");
                                for (int i = input1.Length - 1; i >= 0; i--)
                                {
                                    Console.Write(input1[i]);
                                }
                                Console.WriteLine();
                                break;
                case 2:
                                Console.WriteLine("Input array on a single line with spaces:");
                                string[] input2 = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                while (input2.Length == 0 || !IsValidIntegerSequence(input2))
                                {
                                    Console.WriteLine("Invalid integer sequence. Try again.");
                                    input2 = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                }
                                int[] numbers = input2.Select(x => int.Parse(x)).ToArray();
                                Console.WriteLine("The average is:\n{0}", CalcAverage(numbers));
                                break;
                case 3:
                                Console.WriteLine("Input linear coefficients a and b (ax + b = 0) on a single line separated with space:");
                                string[] input3 = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                while (input3[0] == "0" || !IsValidLinearEqInput(input3))
                                {
                                    Console.WriteLine("Invalid linear equation coefficients. Try again.");
                                    input3 = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                }
                                float[] coef = input3.Select(x => float.Parse(x)).ToArray();
                                Console.WriteLine("The solution is:\n{0}", SolveLinearEq(coef));
                                break;
                default:
                    break;
            }
        }

        static decimal ReverseDigits(decimal num)
        {
            string numStr = num.ToString();
            char[] chars = numStr.ToCharArray();
            Array.Reverse(chars);
            return num = Convert.ToDecimal(new String(chars));
        }

        static float CalcAverage(int[] nums)
        { 
            float sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            float average = sum / nums.Length;
            return average;
        }

        static float SolveLinearEq(float[] coef)
        {
            float solution = 0;
            return solution = coef[1] / coef[0];
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

        static bool IsValidLinearEqInput(string[] input)
        {
            bool isValid = true;
            float tempInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!float.TryParse(input[i], out tempInt) || input.Length != 2)
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        static bool IsValidNumber(char[] input)
        {
            bool isValid = true;
            int countSep = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == ',')
                {
                    countSep++;
                }
                if (!Char.IsDigit(input[i]) && !((input[i] == '.' || input[i] == ',') && countSep < 2))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
