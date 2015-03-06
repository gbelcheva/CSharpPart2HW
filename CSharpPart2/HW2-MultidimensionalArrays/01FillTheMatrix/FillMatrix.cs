using System;

//Problem 1. Fill the matrix

//    Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:
//a) 	b) 	c) 	d)*
//1 	5 	9 	13
//2 	6 	10 	14
//3 	7 	11 	15
//4 	8 	12 	16
	
//1 	8 	9 	16
//2 	7 	10 	15
//3 	6 	11 	14
//4 	5 	12 	13
	
//7 	11 	14 	16
//4 	8 	12 	15
//2 	5 	9 	13
//1 	3 	6 	10
	
//1 	12 	11 	10
//2 	13 	16 	9
//3 	14 	15 	8
//4 	5 	6 	7

namespace _01FillTheMatrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter n for matrix (n x n):");
            int n = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    counter++;
                    matrixA[j, i] = counter;
                }
            }
            Console.WriteLine("Matrix a:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            counter = 0;
            int[,] matrixB = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                if (i %2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        counter++;
                        matrixB[j, i] = counter;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        counter++;
                        matrixB[j, i] = counter;
                    }
                }
                
            }
            Console.WriteLine("Matrix b:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            counter = 0;
            int[,] matrixC = new int[n, n];
            int k = n - 1;
            int l = 0;
            while (k >= 0)
            {
                
                while (k < n)
                {
                    counter++;
                    matrixC[k, l] = counter;
                    k++;
                    l++;
                }
                k = n - 1 - l ;
                l = 0;
            }
            l++;
            while (l < n)
            {
                k = 0;
                while (l < n)
                {
                    counter++;
                    matrixC[k, l] = counter;
                    k++;
                    l++;
                }
                l = n - k + 1;

            }
            Console.WriteLine("Matrix c:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrixC[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
