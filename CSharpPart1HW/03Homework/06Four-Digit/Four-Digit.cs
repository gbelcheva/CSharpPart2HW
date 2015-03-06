using System;

//Problem 6. Four-Digit Number

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//        Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.

//Examples:
//n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
//2011 	4 	1102 	1201 	2101
//3333 	12 	3333 	3333 	3333
//9876 	30 	6789 	6987 	9786

namespace _06Four_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive four-digit integer: ");
            int i;
            while (!(int.TryParse(Console.ReadLine(), out i) && (i > 999 && i < 10000)))
            {
                Console.WriteLine("Invalid number. Try again:\n");
            }
            int firstDigit = i % 10;
            int secondDigit = (i / 10) % 10;
            int thirdDigit = (i / 100) % 10;
            int fourthDigit = (i / 1000) % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("Sum of digits: {0}", sum);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", 
                firstDigit,
                secondDigit,
                thirdDigit,
                fourthDigit);
            Console.WriteLine("Last digit in front: {0}{3}{2}{1}",
                firstDigit,
                secondDigit,
                thirdDigit,
                fourthDigit);
            Console.WriteLine("Second and third digit exchanged: {3}{1}{2}{0}",
                firstDigit,
                secondDigit,
                thirdDigit,
                fourthDigit);
        }
    }
}
