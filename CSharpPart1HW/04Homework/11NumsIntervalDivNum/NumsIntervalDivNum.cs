using System;

//Problem 11.* Numbers in Interval Dividable by Given Number

//    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

//Examples:
//start 	end 	p 	comments
//17 	25 	2 	20, 25
//5 	30 	6 	5, 10, 15, 20, 25, 30
//3 	33 	6 	5, 10, 15, 20, 25, 30
//3 	4 	0 	-
//99 	120 	5 	100, 105, 110, 115, 120
//107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

namespace _11NumsIntervalDivNum
{
    class NumsIntervalDivNum
    {
        static void Main(string[] args)
        {
            Console.Write("Input positive integer interval (start,end):\n");
            int start;
            int end;
            while (!(int.TryParse(Console.ReadLine(), out start) &&
                     int.TryParse(Console.ReadLine(), out end) &&
                     (start > 0 && end > 0 && start < end)))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            while (start % 5 != 0)
            {
                start++;
            }
            while (end % 5 != 0)
            {
                end--;
            }
            int p = ((end - start) / 5) + 1;
            Console.WriteLine("How many numbers divisible by 5: {0}", p);
        }
    }
}
