using System;

//Problem 10. Odd and Even Product

//    You are given n integers (given in a single line, separated by a space).
//    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

//Examples:
//numbers 	result
//2 1 1 6 3 	yes
//product = 6 	
	
//3 10 4 6 5 1 	yes
//product = 60 	
	
//4 3 2 5 2 	no
//odd_product = 16 	
//even_product = 15 	

namespace _10OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input five numbers separated with space:");
            string[] numbers = Console.ReadLine().Split();
            int number;
            int productOdd = 1;
            int productEven = 1;
            for (int i = 1; i <= numbers.Length; i++) 
            {
                number = int.Parse(numbers[i - 1]);
                if (i % 2 == 0) productEven *= number;
                else productOdd *= number;
            }
            bool productsEqual = (productOdd == productEven) ? true : false;
            if (productsEqual) Console.Write("Yes\nProduct = {1}\n", productsEqual, productEven);
            else Console.Write("No\nOdd product = {1}\nEven product = {2}\n", productsEqual, productOdd, productEven);
        }
    }
}
