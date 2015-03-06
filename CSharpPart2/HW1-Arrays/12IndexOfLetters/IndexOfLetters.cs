using System;

//Problem 12. Index of letters

//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.


namespace _12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char [] alphabet= new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }
            Console.WriteLine("Input a word:");
InvalidInput:
            string word = Console.ReadLine().ToLower();
            int[] letterIndexes = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                bool isLetter = false;
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        letterIndexes[i] = j;
                        isLetter = true;
                    }
                }
                if (!isLetter)
                {
                    Console.WriteLine("Input is not word. Try again.");
                    goto InvalidInput;
                }
            }
            Console.WriteLine("The indexes of the letter are:\n{0}", String.Join(" ", letterIndexes));
        }
    }
}
