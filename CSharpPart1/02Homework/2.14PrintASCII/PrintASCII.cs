using System;
using System.Text;

namespace _2._14PrintASCII
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            Console.Title = "Extended ASCII Table";
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            //Output 32x8 table
            for (int i = 0; i < 32; i++) //rows
            {
                for (int j = 0; j < 8; j++) //columns
                {
                    char ch = (char)(i + j * 32);
                    if (char.IsControl(ch))
                    {
                        Console.Write("{0}:\t", i + j * 32);
                    }
                    else
                    {
                        Console.Write("{0}: {1}\t", i + j * 32, ch);
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nNB: Control characters are omitted.");
        }
    }
}


//Problem 14.* Print the ASCII Table

//    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).