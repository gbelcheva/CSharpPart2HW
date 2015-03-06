using System;

//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine

namespace _03EnglishDigit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is:");
            Console.WriteLine(GetEnglishDigit(number));
        }

        private static string GetEnglishDigit(int num)
        {
            string[] digits = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string digit = "";
            for (int i = 0; i < digits.Length; i++)
            {
                if (num % 10 == i)
                {
                    digit = digits[i];
                    return digit;
                }
            }
            return digit;
        }
    }
}
