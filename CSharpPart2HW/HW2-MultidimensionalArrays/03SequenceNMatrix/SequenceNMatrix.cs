using System;
using System.Text;

namespace _03SequenceNMatrix
{
    class SequenceNMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n and m:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            Console.WriteLine("Input matrix:");
            for (int i = 0; i < n; i++)
			{
			 string[] input = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
			    {
			        matrix[i, j] = input[j];
			    }   
			}
            if (n > m)
            {
                n = m + n;
                m = n - m;
                n = n - m;
            }
            int temp = 1;
            int max = 0;
            string element = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i])
                    {
                        temp++;
                    }
                    else if (temp > max)
                    {
                        max = temp;
                        element = matrix[i, j];
                    }
                    else
                    {
                        temp = 1;
                    }
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[j, i] == matrix[j, i + 1])
                    {
                        temp++;
                    }
                    else if (temp > max)
                    {
                        max = temp;
                        element = matrix[i, j];
                    }
                    else
                    {
                        temp = 1;
                    }
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i + 1])
                    {
                        temp++;
                    }
                    else if (temp > max)
                    {
                        max = temp;
                        element = matrix[i, j];
                    }
                    else
                    {
                        temp = 1;
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            for (uint i = 0; i < max; i++)
                result.Append(element + " ");
            result.ToString();
            Console.WriteLine(result);
        }
    }
}
