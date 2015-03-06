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
            float number = float.Parse(Console.ReadLine());
            number = ReverseNum(number);
            Console.WriteLine("Reversed numver is:\n{0}", number);
        }
        static float ReverseNum(float number)
        {
            string numStr = number.ToString();
            char[] chars = numStr.ToCharArray();
            Array.Reverse(chars);
            string reversedStr = new String(chars);
            return number = Convert.ToSingle(reversedStr);
        }
    }
}
