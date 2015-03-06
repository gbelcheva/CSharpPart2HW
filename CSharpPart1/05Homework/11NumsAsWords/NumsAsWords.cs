using System;

//Problem 11.* Number as Words

//    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//Examples:
//numbers 	number as words
//0 	Zero
//9 	Nine
//10 	Ten
//12 	Twelve
//19 	Nineteen
//25 	Twenty five
//98 	Ninety eight
//98 	Ninety eight
//273 	Two hundred and seventy three
//400 	Four hundred
//501 	Five hundred and one
//617 	Six hundred and seventeen
//711 	Seven hundred and eleven
//999 	Nine hundred and ninety nine

namespace _11NumsAsWords
{
    class NumsAsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer [0...999]:");
            int number = int.Parse(Console.ReadLine());
            string[] singlesList = { "zero", "one", "two", "three", "four", 
                                      "five","six", "seven", "eight", "nine", 
                                      "ten", "eleven", "twelve", "thirteen", "fourteen", 
                                      "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] tensList = { "ten", "twenty", "thirty", "fourty", "fifty", 
                                    "sixty", "seventy","eighty", "ninety"};
            if (number < 20)
            {
                Console.WriteLine(singlesList[number]);
            }
            else if (number < 100)
            {
                int singles = number % 10;
                int tens = (number / 10) - 1;
                if (number % 10 == 0) Console.WriteLine(tensList[(number / 10) - 1]);
                else Console.WriteLine(tensList[tens] + " " + singlesList[singles]);
            }
            else 
            {
                int singles = (number % 100) % 10;
                int tens = ((number / 10) % 10);
                int hundreds = number / 100;
                if (number % 100 == 0) Console.WriteLine(singlesList[hundreds] + " hundred");
                else if (number % 10 == 0 && ((number / 10) % 10) != 1) Console.WriteLine(singlesList[hundreds] + " hundred and " + tensList[tens - 1]);
                else if (((number / 10) % 10) == 1) Console.WriteLine(singlesList[hundreds] + " hundred and " + singlesList[singles + 10]);
                else if (((number / 10) % 10) == 0) Console.WriteLine(singlesList[hundreds] + " hundred and " + singlesList[singles]);
                else Console.WriteLine(singlesList[hundreds] + " hundred and " + tensList[tens - 1] + " " + singlesList[singles]);
            }
        }
    }
}
