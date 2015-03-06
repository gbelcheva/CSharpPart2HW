using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormulaBit1
{
    class FormulaBit1
    {
        static void Main(string[] args)
        {
            string[] numbers = new string[8];
            for (int k = 0; k < 8; k++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[k] = Convert.ToString(n, 2).PadLeft(8, '0');
            }
            for (int l = 0; l < 8; l++)
            {
                Console.WriteLine(numbers[l]);
            }
            bool track = false;
            int counter = 1;
            int i = 0;
            int j = 7;
            int turns = -1;
            char position = numbers[0][7];
            while (true)
            {
                //south
                while (position != '1' && i < 7)
                {
                    i++;
                    position = numbers[i][j];
                    counter++;
                }
                if (i == 7 && j == 0)
                {
                    track = true;
                    break;
                }
                if (j - 1 < 0)
                {
                    break;
                }
                position = numbers[i][j - 1];
                if (i == 7 && j - 1 == 0 && numbers[7][0] == '0')
                {
                    turns++;
                    counter++;
                    break;
                }
                if (position == '1')
                {
                    break;
                }
                else
                {
                    turns++;
                }
                //west
                while (position != '1' && j > 0)
                {
                    j--;
                    position = numbers[i][j];
                    counter++;
                }
                if (i == 7 && j == 0)
                {
                    track = true;
                    break;
                }
                if (i - 1 < 0)
                {
                    break;
                }
                position = numbers[i - 1][j];
                if (i - 1 == 7 && j == 0 && numbers[7][0] == '0')
                {
                    turns++;
                    counter++;
                    break;
                }
                if (position == '1')
                {
                    break;
                }
                else
                {
                    turns++;
                }
                //north
                while (position != '1' && i > 0)
                {
                    i--;
                    position = numbers[i][j];
                    counter++;
                }
                if (i == 7 && j == 0)
                {
                    track = true;
                    break;
                }
                if (j - 1 < 0)
                {
                    break;
                }
                position = numbers[i][j - 1];
                if (i == 7 && j - 1 == 0 && numbers[7][0] == '0')
                {
                    turns++;
                    counter++;
                    break;
                }
                if (position == '1')
                {
                    break;
                }
                else
                {
                    turns++;
                }
                //west
                while (position != '1' && j > 0)
                {
                    j--;
                    position = numbers[i][j];
                    counter++;
                }
                if (i == 7 && j == 0)
                {
                    track = true;
                    break;
                }
                if (i + 1 > 7)
                {
                    break;
                }
                position = numbers[i + 1][j];
                if (i + 1 == 7 && j == 0 && numbers[7][0] == '0')
                {
                    turns++;
                    counter++;
                    break;
                }
                if (position == '1')
                {
                    break;
                }
                else
                {
                    turns++;
                }
            }
            if (track)
            {
                Console.WriteLine("{0} {1}", counter, turns);
            }
            else
            {
                Console.WriteLine("No {0}", counter);
            }
            
        }
    }
}
