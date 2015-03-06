using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] secret = Console.ReadLine().ToCharArray();
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            const char usedSecret = '*';
            const char usedCurrent = '@';
            string found = "";
            for (int i = 1000; i <= 9999; i++)
            {
                byte bulls = 0;
                byte cows = 0;
                char[] current = Convert.ToString(i).ToCharArray();
                for (int j = 0; j < 4; j++)
                {
                    if (secret[j] == current[j])
                    {
                        bulls++;
                        secret[j] = used;
                        current[j] = used;
                    }
                }
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (secret[j] == current[k])
                        {
                            cows++;
                            secret[j] = used;
                            current[k] = used;
                        }
                    }
                }
                if (cows == c && bulls == b)
                {
                    found = found + current + " ";
                }
            }
            if (found == "")
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(found);
            }

        }

        static int[] Sort(int[] numbers)
        {
            int n = numbers.Length;
            int[] sorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                int smallerNumsCount = 0;
                int equalNumsCount = 0;
                for (int j = 0; j < n; j++)
                {
                    smallerNumsCount = numbers[i] > numbers[j] ? smallerNumsCount = smallerNumsCount + 1 : smallerNumsCount;
                    equalNumsCount = numbers[i] == numbers[j] ? equalNumsCount = equalNumsCount + 1 : equalNumsCount;
                }
                for (int j = smallerNumsCount; j < smallerNumsCount + equalNumsCount; j++)
                {
                    sorted[j] = numbers[i];
                }
            }
            return sorted;
        }
    }
}
