using System;

//Problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).


namespace _03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two char arrays, each on a single line, with no separation between the elements.\n");
            string[] charArrOriginal = new string[2];
            string[] charArr = new string[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Input char array{0}:", i + 1);
                charArrOriginal[i] = Console.ReadLine();
                charArr[i] = charArrOriginal[i].ToLower();
            }
            bool same = true;
            int counter = 0;
            while (counter < charArr[0].Length && counter < charArr[1].Length)
            {
                if (charArr[0][counter] < charArr[1][counter])
                {
                    Console.WriteLine("{0} is smaller than {1}.", charArrOriginal[0], charArrOriginal[1]);
                    same = false;
                    break;
                }
                else if (charArr[0][counter] > charArr[1][counter])
                {
                    Console.WriteLine("{0} is bigger than {1}.", charArrOriginal[0], charArrOriginal[1]);
                    same = false;
                    break;
                }
                counter++;
            }

            if (same)
            {
                if (charArr[0].Length == charArr[1].Length)
                {
                    Console.WriteLine("{0} is the same as {1}.", charArrOriginal[0], charArrOriginal[1]);
                }
                else if (charArr[0].Length < charArr[1].Length)
                {
                    Console.WriteLine("{0} is smaller than {1}.", charArrOriginal[0], charArrOriginal[1]);
                }
                else
                {
                    Console.WriteLine("{0} is bigger than {1}.", charArrOriginal[0], charArrOriginal[1]);
                }
            }
        }
    }
}
