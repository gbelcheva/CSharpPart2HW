using System;

//Problem 3. Divide by 7 and 5

//    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

//Examples:
//n 	Divided by 7 and 5?
//3 	false
//0 	false
//5 	false
//7 	false
//35 	true
//140 	true

namespace _03Divide7and5
{
    class Divide7and5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.WriteLine("Invalid number.\n");
            }
            bool isDivisible = ((n % 5 == 0) && (n % 7 == 0)); //zero is divisible by 5 and 7 and everything else
            Console.WriteLine("Divisible by 5 and 7 at the same time?\n{0}", isDivisible);
        }
    }
}
