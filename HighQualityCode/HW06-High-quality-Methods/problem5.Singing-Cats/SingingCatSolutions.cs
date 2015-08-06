namespace ConsoleApplication5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SingingCatsSolution
    {
        public static void Main(string[] args)
        {
            string[] numberOfCatsString = Console.ReadLine().Split(' ');
            int numberOfCats = int.Parse(numberOfCatsString[0]);

            string[] numberOfSongsString = Console.ReadLine().Split(' ');
            int numberOfSongs = int.Parse(numberOfSongsString[0]);

            List<string> inputLines = new List<string>();
            string input = Console.ReadLine();
            while (input != "Mew!")
            {
                inputLines.Add(input);
                input = Console.ReadLine();
            }

            int[,] catsSongsArray = new int[numberOfCats, numberOfSongs];
            for (int lineNumber = 0; lineNumber < inputLines.Count; lineNumber++)
            {
                numberOfSongsString = inputLines[lineNumber].Split(' ');
                catsSongsArray[(int.Parse(numberOfSongsString[1]) - 1), (int.Parse(numberOfSongsString[4]) - 1)] = 1;
            }

            if (!CheckIfEveryCatKnowsASong(catsSongsArray))
            {
                Console.WriteLine("No concert!");
            }

            int totalSongs = 0;

            List<int> colSums = new List<int>();
            List<int> colIndex = new List<int>();

            for (int songIndex = 0; songIndex < numberOfSongs; songIndex++)
            {
                int sum = SumArrayCol(songIndex, catsSongsArray, numberOfCats);
                colSums.Add(sum);
                colIndex.Add(songIndex);
            }

            int[] currentColumn = new int[numberOfCats];

            for (int songIndex = 0; songIndex < numberOfSongs; songIndex++)
            {
                int maxElement = colSums.Max();
                int maxIndex = colIndex[colSums.IndexOf(maxElement)];

                bool isDiff = false;

                for (int catIndex = 0; catIndex < numberOfCats; catIndex++)
                {
                    if (currentColumn[catIndex] != 1 && catsSongsArray[catIndex, maxIndex % numberOfSongs] == 1)
                    {
                        currentColumn[catIndex] = catsSongsArray[catIndex, maxIndex % numberOfSongs];
                        isDiff = true;
                    }
                }

                if (isDiff)
                {
                    totalSongs++;
                }

                colSums.RemoveAt(maxIndex);
                colSums.Insert(maxIndex, int.MinValue);
            }

            Console.WriteLine(totalSongs);
        }

        private static bool CheckIfEveryCatKnowsASong(int[,] catsSongsArray) 
        {
            for (int catIndex = 0; catIndex < catsSongsArray.GetLength(1); catIndex++)
            {
                int sum = 0;

                sum = SumArrayRow(catIndex, catsSongsArray, catsSongsArray.GetLength(0));
                if (sum == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int SumArrayRow(int row, int[,] matrix, int numberOfCols)
        {
            int sum = 0;

            for (int i = 0; i < numberOfCols; i++)
            {
                sum += matrix[row, i];
            }

            return sum;
        }

        private static int SumArrayCol(int col, int[,] matrix, int numberOfRows)
        {
            int sum = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                sum += matrix[i, col];
            }

            return sum;
        }
    }
}