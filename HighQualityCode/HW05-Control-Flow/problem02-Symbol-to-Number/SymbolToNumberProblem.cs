namespace Task04
{
    using System;

    public class SymbolToNumberProblem
    {
        public static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double encodedTextCharacterAsNumber = 1;
            char currentCharacter;

            for (int i = 0; i < text.Length; i++)
            {
                currentCharacter = text[i];

                if (currentCharacter == '@')
                {
                    return;
                }
                else if (char.IsLetter(currentCharacter))
                {
                    encodedTextCharacterAsNumber = (currentCharacter * secretNumber) + 1000;
                }
                else if (char.IsDigit(currentCharacter))
                {
                    encodedTextCharacterAsNumber = currentCharacter + secretNumber + 500;
                }
                else
                {
                    encodedTextCharacterAsNumber = currentCharacter - secretNumber;
                }

                if (i % 2 == 0)
                {
                    encodedTextCharacterAsNumber = encodedTextCharacterAsNumber / 100.0;
                    Console.WriteLine("{0:F2}", encodedTextCharacterAsNumber);
                }
                else
                {
                    encodedTextCharacterAsNumber = encodedTextCharacterAsNumber * 100;
                    Console.WriteLine(encodedTextCharacterAsNumber);
                }
            }
        }
    }
}