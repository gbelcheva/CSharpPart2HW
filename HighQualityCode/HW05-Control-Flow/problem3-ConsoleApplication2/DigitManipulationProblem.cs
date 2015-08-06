namespace Task04
{
    using System;
    using System.Numerics;

    public class DigitManipulationProblem
    {
        public static void Main(string[] args)
        {
            string currentLineInput;
            string[] inputNumbersAsStrings = new string[10001];
            long totalNumbersCount = 0;

            while (true)
            {
                currentLineInput = Console.ReadLine();

                if (currentLineInput == "END")
                {
                    break;
                }

                inputNumbersAsStrings[totalNumbersCount] = currentLineInput;
                totalNumbersCount++;
            }

            if (totalNumbersCount > 10)
            {
                ulong numberAfterFilteringForZeros;
                BigInteger finalProductOfFirstTenNumbers = 1;
                BigInteger finalProductOfAllNumbersExceptFirstTen = 1;
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        numberAfterFilteringForZeros = 1;

                        for (int j = 0; j < inputNumbersAsStrings[i].Length; j++)
                        {
                            if (inputNumbersAsStrings[i] == "0")
                            {
                                numberAfterFilteringForZeros = 1;

                                break;
                            }

                            if (inputNumbersAsStrings[i][j] == '0')
                            {
                                continue;
                            }

                            numberAfterFilteringForZeros *= (ulong)(inputNumbersAsStrings[i][j] - '0');
                        }

                        finalProductOfFirstTenNumbers *= numberAfterFilteringForZeros;
                    }
                }

                for (int i = 10; i < totalNumbersCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        numberAfterFilteringForZeros = 1;

                        for (int j = 0; j < inputNumbersAsStrings[i].Length; j++)
                        {
                            if (inputNumbersAsStrings[i] == "0")
                            {
                                numberAfterFilteringForZeros = 1;

                                break;
                            }

                            if (inputNumbersAsStrings[i][j] == '0')
                            {
                                continue;
                            }

                            numberAfterFilteringForZeros *= (ulong)(inputNumbersAsStrings[i][j] - '0');
                        }

                        finalProductOfAllNumbersExceptFirstTen *= numberAfterFilteringForZeros;
                    }
                }

                Console.WriteLine(
                    "{0}\n{1}", 
                    finalProductOfFirstTenNumbers, 
                    finalProductOfAllNumbersExceptFirstTen);
            }
            else
            {
                ulong numberAfterFilteringForZeros;
                BigInteger finalProductOfAllNumbers = 1;

                for (int i = 0; i < totalNumbersCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        numberAfterFilteringForZeros = 1;

                        for (int j = 0; j < inputNumbersAsStrings[i].Length; j++)
                        {
                            if (inputNumbersAsStrings[i] == "0")
                            {
                                numberAfterFilteringForZeros = 1;

                                break;
                            }

                            if (inputNumbersAsStrings[i][j] == '0')
                            {
                                continue;
                            }

                            numberAfterFilteringForZeros *= (ulong)(inputNumbersAsStrings[i][j] - '0');
                        }

                        finalProductOfAllNumbers *= numberAfterFilteringForZeros;
                    }
                }

                Console.WriteLine(finalProductOfAllNumbers);
            }
        }
    }
}