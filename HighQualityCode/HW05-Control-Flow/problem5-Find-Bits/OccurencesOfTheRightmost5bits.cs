namespace Task04
{
    using System;

    public class OccurencesOfTheRightmost5bits
    {
        private const int NumberOfRightmostbitsToSearch = 5;
        private const int NumberOfRightmostbitsToSearchInto = 29;

        public static void Main(string[] args)
        {
            int numberS = int.Parse(Console.ReadLine());
            string numberSAsBinaryString = Convert.ToString(numberS, 2).PadLeft(32, '0');
            int totalNumbersCount = int.Parse(Console.ReadLine());
            string[] allNumbersAsBinaryString = new string[totalNumbersCount];
            int parsedNumber;

            for (int i = 0; i < totalNumbersCount; i++)
            {
                parsedNumber = int.Parse(Console.ReadLine());

                allNumbersAsBinaryString[i] = Convert.ToString(parsedNumber, 2).PadLeft(29, '0');
            }

            string rightmostFiveBits = string.Empty;
            int occurenceCount = 0;

            for (int i = numberSAsBinaryString.Length - 5; i < numberSAsBinaryString.Length; i++)
            {
                rightmostFiveBits = rightmostFiveBits + numberSAsBinaryString[i];
            }

            for (int i = 0; i < totalNumbersCount; i++)
            {
                for (int j = allNumbersAsBinaryString[i].Length - NumberOfRightmostbitsToSearch; j > allNumbersAsBinaryString[i].Length - NumberOfRightmostbitsToSearchInto - 1; j--)
                {
                    char[] currentFiveBits = 
                    { 
                                                 allNumbersAsBinaryString[i][j], 
                                                 allNumbersAsBinaryString[i][j + 1], 
                                                 allNumbersAsBinaryString[i][j + 2], 
                                                 allNumbersAsBinaryString[i][j + 3], 
                                                 allNumbersAsBinaryString[i][j + 4] 
                    };

                    string currentFiveBitsAsString = new string(currentFiveBits);

                    if (rightmostFiveBits == currentFiveBitsAsString)
                    {
                        occurenceCount++;
                    }
                }
            }

            Console.WriteLine(occurenceCount);
        }
    }
}