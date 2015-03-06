using System;

//Problem 9. Sum of n Numbers

//    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

//Examples:
//numbers 	sum
//3 	90
//20 	
//60 	
//10 	
//5 	6.5
//2 	
//-1 	
//-0.5 	
//4 	
//2 	
//1 	1
//1 	

namespace _09SumNNumbers
{
    class SumNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n;
            while (! int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            Double[] numbers = new Double[n];
            double sum = 0;
            Console.WriteLine("Input {0} numbers:", n);
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                sum = sum + numbers[i];
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
