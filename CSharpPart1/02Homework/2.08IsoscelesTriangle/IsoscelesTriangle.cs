using System;
using System.Linq;
using System.Text;

namespace _2._08IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Input height: ");
            int n = 4;//int.Parse(Console.ReadLine());
            char symbol = '\u00A9';
            string firstSpaces = new string(' ', n - 1);
            Console.WriteLine(firstSpaces + symbol + firstSpaces);
            for (int i = 0; i < n - 2; i++)
            {
                int outerCount = n - (i + 2);
                int innerCount = 2 * i + 1;
                string outerSpaces = new string(' ', outerCount);
                string innerSpaces = new string(' ', innerCount);
                Console.WriteLine(outerSpaces + symbol + innerSpaces + symbol + outerSpaces);
            }
            char[] lastChars = { symbol, ' ' };
            string lastRow = new string(lastChars);
            Console.WriteLine(string.Concat(Enumerable.Repeat(lastRow, n)));
        }
    }
}

//Problem 8. Isosceles Triangle

//    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//   ©

//  © ©

// ©   ©

//© © © ©

//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.