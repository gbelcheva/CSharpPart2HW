using System;

//Problem 2. Random numbers

//    Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02RandomNumbers
{
    class RandomNumbers
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int[] values = new int[100];
            for (int i = 0; i < 100; i++)
            {
                values[i] = (int)(i + 100);
            }
            Randomise(values);
            for (int i = 0; i < 9; i++)
            {
                Console.Write(values[i] + " ");
            }
            Console.WriteLine(values[9]);
        }
        public static void Randomise(int[] list)
        {

            for (int i = list.Length - 1; i > 0; i--)
            {
                int swapIndex = r.Next(i + 1);
                if (swapIndex != i)
                {
                    int tmp = list[swapIndex];
                    list[swapIndex] = list[i];
                    list[i] = tmp;
                }
            }
        }
    }
}
