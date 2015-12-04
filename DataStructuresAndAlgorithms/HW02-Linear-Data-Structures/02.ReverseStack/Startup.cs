//Write a program that reads N integers from the console and reverses them using a stack.

//    Use the Stack<int> class.


namespace ReverseStack
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input sequence:");
            var inputSequence = new Stack<int>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == string.Empty)
                {
                    break;
                }

                int inputNumber = Int32.Parse(inputLine);

                inputSequence.Push(inputNumber);
            }

            Console.WriteLine(string.Join(" ", inputSequence));
        }
    }
}
