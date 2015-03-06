using System;
using System.Text;

namespace _2._04UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char variable = '\u002A';
            Console.WriteLine(variable);
        }
    }
}


//Problem 4. Unicode Character

//    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.