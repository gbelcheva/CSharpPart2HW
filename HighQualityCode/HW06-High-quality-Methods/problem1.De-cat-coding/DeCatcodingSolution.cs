namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DeCatcodingSolution
    {
        public static void Main(string[] args)
        {
            string[] encodedWords = Console.ReadLine().Split(' ');

            string decodedWord;
            List<string> decodedWords = new List<string>();
            foreach (string word in encodedWords)
            {
                decodedWord = DecodeWordFromBase21ToBase26(word);
                decodedWords.Add(decodedWord);
            }

            Console.WriteLine(string.Join(" ", decodedWords));
        }

        /// <summary>
        /// Decodes a word from base 21 system to a base 26 system.
        /// </summary>
        /// <param name="encodedWord">The word to be decoded.</param>
        /// <returns>The decoded word.</returns>
        private static string DecodeWordFromBase21ToBase26(string encodedWord) 
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            long decimalRepresentation = 0;
            long multiplicator = 1;
            StringBuilder decodedWordLettersAsStringBuilder = new StringBuilder();

            for (int i = encodedWord.Length - 1; i >= 0; i--)
            {
                decimalRepresentation += (encodedWord[i] - 'a') * multiplicator;
                multiplicator *= 21;
            }

            while (decimalRepresentation >= 26)
            {
                decodedWordLettersAsStringBuilder.Append(letters[decimalRepresentation % 26]);
                decimalRepresentation /= 26;
            }

            decodedWordLettersAsStringBuilder.Append(letters[decimalRepresentation % 26]);
            char[] decodedWordLetters = decodedWordLettersAsStringBuilder.ToString().ToCharArray();
            Array.Reverse(decodedWordLetters);

            return new string(decodedWordLetters);
        }
    }
}