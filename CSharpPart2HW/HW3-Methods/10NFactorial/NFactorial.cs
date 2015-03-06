using System;
using System.Linq;
using _08NumberAsArray;

//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

namespace _10NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N to calculate N!:");
            int input;
            while (!int.TryParse(Console.ReadLine() , out input) )
            {
                Console.WriteLine("Incorrect input.Try again.");
            }
            while (!(0 <= input && input <= 100))
            {
                Console.WriteLine("Incorrect input.Try again.");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Incorrect input.Try again.");
                }
            }
            if (input == 0)
            {
                input = 1;
            }
            int[] factProduct = { input };
            for (int i = 1; i < input; i++)
            {
                factProduct = MultiplyLargeNums(factProduct, new int[] { i });
            }
            Console.WriteLine("The factorial is:");
            for (int i = factProduct.Length - 1; i >= 0; i--)
            {
                Console.Write(factProduct[i]);
            }
            Console.WriteLine();
        }
        static int[] MultiplyLargeNums(int[] num1, int[] num2)
        {
            int[] product = new int[num1.Length + num2.Length];
            int carry = 0;
            product[0] = carry;
            for (int j = 0; j < num2.Length; j++)
            {
                int[] tempProduct = new int[num1.Length + num2.Length];
                for (int i = j; i < num1.Length + j; i++)
                {
                    carry = (tempProduct[i] + (num1[i - j] * num2[j])) / 10;
                    tempProduct[i] = (tempProduct[i] + (num1[i - j] * num2[j])) % 10;
                    tempProduct[i + 1] = carry;
                }
                product = _08NumberAsArray.NumberAsArray.AddNumbersAsArray(product, tempProduct);
            }
            if (product[product.Length - 1] == 0)
            {
                Array.Resize(ref product, product.Length - 1);
            }

            return product;

        }
    }
}
