using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class GameOfPage
    {
        static void Main(string[] args)
        {
            char[,] tray = new char[18, 18];
            string[] line = new string[18];
            line[0] = new String('0', 18);
            line[17] = new String('0', 18);
            for (int i = 0; i < 2; i += 17)
            {
                for (int j = 0; j < 18; j++)
                {
                    tray[i, j] = line[i][j];
                }
            }
            for (int i = 1; i < 17; i++)
            {
                line[i] = "0" + Console.ReadLine() + "0";
                for (int j = 0; j < 18; j++)
                {
                    tray[i, j] = line[i][j];
                }
            }
            double cookie = 0;
            bool payNow = false;
            while (!payNow)
            {
                int x, y;
                switch (Console.ReadLine())
                {
                    case "what is": 
                        x = int.Parse(Console.ReadLine()) + 1;
                        y = int.Parse(Console.ReadLine()) + 1;
                        Console.WriteLine(WhatIs(tray, x, y));
                        break;
                    case "buy":
                        x = int.Parse(Console.ReadLine()) + 1;
                        y = int.Parse(Console.ReadLine()) + 1;
                        if (Buy(tray, x, y) != "cookie")
                        {
                            Console.WriteLine(Buy(tray, x, y));
                        }
                        else
                        {
                            cookie++;
                        }
                        break;
                    case "paypal":
                        payNow = true;
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine("{0:F2}", Pay(cookie));
        }

        static string WhatIs(char[,] tray, int x, int y) 
        {
            string answer = "";
            if (tray[x, y] == '0')
            {
                answer = "smile";
            }
            else if (tray[x - 1, y - 1] == '1' &&
                     tray[x - 1, y] == '1' &&
                     tray[x - 1, y + 1] == '1' &&
                     tray[x, y - 1] == '1' &&
                     tray[x, y + 1] == '1' &&
                     tray[x + 1, y - 1] == '1' &&
                     tray[x + 1, y] == '1' &&
                     tray[x + 1, y + 1] == '1')
            {
                answer = "cookie";
            }
            else if (tray[x - 1, y - 1] == '1' ||
                     tray[x - 1, y] == '1' ||
                     tray[x - 1, y + 1] == '1' ||
                     tray[x, y - 1] == '1' ||
                     tray[x, y + 1] == '1' ||
                     tray[x + 1, y - 1] == '1' ||
                     tray[x + 1, y] == '1' ||
                     tray[x + 1, y + 1] == '1')
            {
                answer = "broken cookie";
            }

            else
            {
                answer = "cookie crumb";
            }
            return answer;
        }
        static string Buy(char[,] tray, int x, int y)
        {
            string answer = "";
            if (tray[x, y] == '0')
            {
                answer = "smile";
            }
            else if (tray[x - 1, y - 1] == '1' &&
                     tray[x - 1, y] == '1' &&
                     tray[x - 1, y + 1] == '1' &&
                     tray[x, y - 1] == '1' &&
                     tray[x, y + 1] == '1' &&
                     tray[x + 1, y - 1] == '1' &&
                     tray[x + 1, y] == '1' &&
                     tray[x + 1, y + 1] == '1')
            {
                answer = "cookie";
                tray[x - 1, y - 1] = '0';
                tray[x - 1, y] = '0';
                tray[x - 1, y + 1] = '0';
                tray[x, y - 1] = '0';
                tray[x, y + 1] = '0';
                tray[x + 1, y - 1] = '0';
                tray[x + 1, y] = '0';
                tray[x + 1, y + 1] = '0';
                tray[x, y] = '0';
            }
            else if (tray[x - 1, y - 1] == '1' ||
                     tray[x - 1, y] == '1' ||
                     tray[x - 1, y + 1] == '1' ||
                     tray[x, y - 1] == '1' ||
                     tray[x, y + 1] == '1' ||
                     tray[x + 1, y - 1] == '1' ||
                     tray[x + 1, y] == '1' ||
                     tray[x + 1, y + 1] == '1')
            {
                answer = "page";
            }

            else
            {
                answer = "page";
            }
            return answer;
        }
        static double Pay(double cookie)
        {
            double amount = 1.79 * cookie;
            return amount;
        }
    }
}
