using System;

//Problem 8. Prime Number Check

//    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//    Note: You should check if the number is positive

//Examples:
//n 	Prime?
//1 	false
//2 	true
//3 	true
//4 	false
//9 	false
//97 	true
//51 	false
//-3 	false
//0 	false

namespace _08PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive integer n <= 100: ");
            sbyte n;
            while (!(sbyte.TryParse(Console.ReadLine(), out n) && (n <= 100)))
            {
                Console.WriteLine("Invalid number.\n");
            }
            bool isPrime = (n > 1);
            for (byte i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("Prime?\n{0}", isPrime);
        }
    }
}
