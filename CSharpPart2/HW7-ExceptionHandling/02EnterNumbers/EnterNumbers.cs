using System;

//Problem 2. Enter numbers

//    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//        If an invalid number or non-number text is entered, the method should throw an exception.
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


namespace _02EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int n = ReadNumber(min, max);
                    min = n;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentOutOfRangeException ore)
            {
                Console.WriteLine(ore.Message);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter integer in range ({0}...{1}):0", start, end);
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                throw new FormatException("The number is invalid or non-number text is entered");
            }
            if (n <= start || end <= n)
                throw new ArgumentOutOfRangeException("The number should be in the interval (" + start + "..." + end + ")");
            return n;
        }
    }
}
