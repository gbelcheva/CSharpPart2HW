namespace Task04
{
    using System;

    public class ThreeNumbersProblem
    {
        public static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            double average;
            long biggestNumber;
            long smallestNumber;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                biggestNumber = firstNumber;

                if (secondNumber > thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = secondNumber;
                }
            }
            else if (secondNumber > thirdNumber)
            {
                biggestNumber = secondNumber;

                if (firstNumber > thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }
            else
            {
                biggestNumber = thirdNumber;
                if (firstNumber > secondNumber)
                {
                    smallestNumber = secondNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }

            average = (firstNumber + secondNumber + thirdNumber) / 3.0;

            Console.WriteLine("{0}\n{1}\n{2:F3}", biggestNumber, smallestNumber, average);
        }
    }
}