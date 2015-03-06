using System;

//Problem 3. Min, Max, Sum and Average of N Numbers

//    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//    The output is like in the examples below.

//Example 1:
//input 	output
//3
//2
//5
//1 	min = 1
//max = 5
//sum = 8
//avg = 2.67

//Example 2:
//input 	output
//2
//-1
//4 	min = -1
//max = 4
//sum = 3
//avg = 1.50

namespace _03MinMaxSumAvg
{
    class MinMaxSumAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer n and then n integers:");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n > 0))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            int number;
            int min = 0;
            int max = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                min = number < min ? number : min;
                max = number > max ? number : max;
                sum += number;   
            }
            float avg = sum / (float)n;
            Console.WriteLine("Min = {0}\nMax = {1}\nSum = {2}\nAvg = {3:0.00}", min, max, sum, avg);
        }
    }
}
