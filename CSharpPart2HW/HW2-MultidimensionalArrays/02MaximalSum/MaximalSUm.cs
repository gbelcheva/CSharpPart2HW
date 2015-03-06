using System;

//Problem 2. Maximal sum

//    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


namespace _02MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n and m:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,m];
            Console.WriteLine("Input each rows on a single line, elements separated with a space:");
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
			    {
			        matrix[i, j] = int.Parse(input[j]);
			    }   
            }
            int sum = 0;
            int maxSum = 0;
            int rowIndex = 0;
            int colIndex = 0;
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < m - 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            sum += matrix[i + k, j + l];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = i;
                        colIndex = j;

                    }
                    sum = 0;
                }
            }
            for (int k = rowIndex; k < 3; k++)
            {
                for (int l = colIndex; l < 3; l++)
                {
                    Console.Write(matrix[k , l] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);

            
        }
    }
}
