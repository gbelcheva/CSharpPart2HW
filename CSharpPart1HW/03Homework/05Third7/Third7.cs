using System;

//Problem 5. Third Digit is 7?

//    Write an expression that checks for given integer if its third digit from right-to-left is 7.

//Examples:
//n 	Third digit 7?
//5 	false
//701 	true
//9703 	true
//877 	false
//777877 	false
//9999799 	true

namespace _05Third7
{
    class Third7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            int n = int.Parse(Console.ReadLine());
            int thirdDigit = (n / 100) % 10;
            bool thirdIs7 = (n >= 100) && (thirdDigit == 7);
            Console.WriteLine("Third digit is 7?\n{0}", thirdIs7);
        }
    }
}
