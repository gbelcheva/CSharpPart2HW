using System;

namespace _15PrimeNumbersSieve
{
    class PrimeNumbersSieve
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            int[] numbers = new int[n + 1];
            numbers[0] = -1;
            numbers[1] = -1;
            int j = 2;
            int p = j;
            while (p <= n)
            {
                int temp = p + p;
                while (temp <= n)
                {
                    numbers[temp] = -1;
                    temp += p;
                }
                int i = 1;
                while (p + i < n)
                {
                    if (numbers[p + i] < 0)
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        p = p + i;
                        break;
                    }
                }
                if (p + p == temp)
                {
                    break;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            
        }
    }
}
