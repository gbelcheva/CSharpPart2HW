using System;

namespace _2._12NullArithmetic
{
    class NullArithmetic
    {
        static void Main(string[] args)
        {
            int? integerVar = null;
            double? doubleVar = null;
            Console.WriteLine(integerVar + " " + doubleVar);
            integerVar = integerVar + null;
            doubleVar = doubleVar + null;
            Console.WriteLine(integerVar + " " + doubleVar);
            integerVar = integerVar + 1;
            doubleVar = doubleVar + 1;
            Console.WriteLine(integerVar + " " + doubleVar);
        }
    }
}


//Problem 12. Null Values Arithmetic

//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.
