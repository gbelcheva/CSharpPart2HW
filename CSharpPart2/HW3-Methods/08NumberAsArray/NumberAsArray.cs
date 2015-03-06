using System;
using System.Linq;
using System.Collections.Generic;
//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

namespace _08NumberAsArray
{
    public class NumberAsArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            char[] input = Console.ReadLine().ToCharArray();
            int[] number1 = input.Select(x => x - 48).ToArray();
            Array.Reverse(number1);
            Console.WriteLine("Input second integer number:");
            input = Console.ReadLine().ToCharArray();
            int[] number2 = input.Select(x => x - 48).ToArray();
            Array.Reverse(number2);
            int[] added = AddNumbersAsArray(number1, number2);
            Console.WriteLine("The sum is:");
            for (int i = added.Length - 1; i >= 0; i--)
            {
                Console.Write(added[i]);
            }
            Console.WriteLine();

        }

        public static int[] AddNumbersAsArray(int[] number1, int[] number2)
        {
            if (number1.Length < number2.Length)
            {
                Array.Resize(ref number1, number2.Length);
            }
            else if (number2.Length < number1.Length)
            {
                Array.Resize(ref number2, number1.Length);
            }
            int[] addResult = new int[number1.Length + 1];
            int carry = 0;
            addResult[0] = carry;
            for (int i = 0; i < number1.Length; i++)
            {
                carry = (addResult[i] + number1[i] + number2[i]) / 10;
                addResult[i] = (addResult[i] + number1[i] + number2[i]) % 10;
                addResult[i + 1] = carry;
            }
            if (addResult[addResult.Length - 1] == 0)
            {
                Array.Resize(ref addResult, addResult.Length - 1);
            }
            return addResult;
        }
    }
}
