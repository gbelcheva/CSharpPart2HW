using System;

//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	652
//123.45	54.321

namespace _07ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input decimal number:");
            decimal number;
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input.Try again.");
            }
            number = ReverseNum(number);
            Console.WriteLine("Reversed number is:\n{0}", number);
        }
        static decimal ReverseNum(decimal number)
        {
            string numStr = number.ToString();
            char[] chars = numStr.ToCharArray();
            Array.Reverse(chars);
            return number = Convert.ToDecimal(new String(chars));
        }
    }
}
