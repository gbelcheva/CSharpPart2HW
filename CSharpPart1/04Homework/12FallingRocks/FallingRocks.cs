using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;

//Problem 12.** Falling Rocks

//    Implement the "Falling Rocks" game in the text console.
//        A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//        A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//        Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//    Ensure a constant game speed by Thread.Sleep(150).
//    Implement collision detection and scoring system.


namespace _12FallingRocks
{
    class FallingRocks
    {
        static void Main(string[] args)
        {
            
            Console.Title = "FALLING ROCKS";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int width = 61;
            int height = 25;
            Console.SetWindowSize(width + 1, height + 1);
            char[] rocks = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-'};
            string[] lines = new string[height];
            int countLeft;
            int countRight;
            ScreenElements(height, width, out lines, out countLeft, out countRight);
            bool gameOver = false;
            int denser = 0;
            int speed = 1;
            do
            {
                Console.Clear();
                TitleScreen(height, width);
                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
                while (true)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if (cki.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    if (cki.Key == ConsoleKey.D2)
                    {
                        denser = 1;
                        speed = 3;
                        break;
                    }
                    if (cki.Key == ConsoleKey.D3)
                    {
                        denser = 1;
                        speed = 5;
                        break;
                    }
                    if (cki.Key == ConsoleKey.D4)
                    {
                        denser = 53;
                        speed = 4;
                        break;
                    }
                }
                
                
                Console.Clear();
                int sc = 0;
                int time = 0;
                int score = 0;
                while (!gameOver)
                {
                    Random r = new Random();
                    int density = (r.Next(0, rocks.Length + 1) / 2 + denser);
                    density = density < 0 ? 0 : density;
                    int countSpaces = width - density;
                    int countSpacesChunk = r.Next(0, countSpaces + 1) / 2;
                    int spacesAvail = countSpaces - countSpacesChunk;
                    string line = "";
                    for (int i = 0; i < density; i++)
                    {
                        line = line.PadRight(line.Length + countSpacesChunk, ' ');
                        line = line + Convert.ToString(rocks[r.Next(0, 12)]);
                        countSpacesChunk = r.Next(0, spacesAvail);
                        spacesAvail = spacesAvail - countSpacesChunk;
                    }
                    line = line.PadRight(width, ' ');
                    lines[0] = line;
                    for (int i = 0; i < height; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                    Thread.Sleep(150 / speed);
                    Console.Clear();
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            countLeft = countLeft - 2;
                            countRight = countRight + 2;
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            countLeft = countLeft + 2;
                            countRight = countRight - 2;
                        }
                    }
                    countRight = countRight < 0 ? 0 : countRight;
                    countLeft = countLeft < 0 ? 0 : countLeft;
                    countRight = countRight > width - 3 ? width - 3 : countRight;
                    countLeft = countLeft > width - 3 ? width - 3 : countLeft;
                    lines[height - 1] = lines[height - 2].Substring(0, countLeft) + "(0)" + lines[height - 2].Substring(countLeft + 3, countRight);
                    gameOver = lines[height - 2].Substring(countLeft, 3) == "   " ? false : true;
                    for (int i = height - 2; i >= 1; i--)
                    {
                        lines[i] = lines[i - 1];
                    }
                    sc++;
                    time = time + 150;
                    score = score + 1 + (sc / (70 - 1 * (sc / 70)));
                }
                ScreenElements(height, width, out lines, out countLeft, out countRight);
                gameOver = false;
                denser = 0;
                speed = 1;
                Console.Clear();
                GameOverScreen(height, width, score, time);
                while (true)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if (cki.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }


        static void TitleScreen(int height, int width) 
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new String('\n', height / 2 - 3));
            Console.WriteLine(String.Format("{0," + (width + "F A L L I N G  R O C K S".Length) / 2 + "}", "F A L L I N G  R O C K S"));
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.WriteLine(String.Format("{0," + (width + "Press ENTER to start".Length) / 2 + "}", "Press ENTER to start"));
            Console.WriteLine("{0," + (width + "Press ESC to quit".Length) / 2 + "}", "Press ESC to qiut");
            Console.WriteLine(new String('\n', height / 2 - 4));
            Console.WriteLine(String.Format("{0," + (width + "Press 2 for expert".Length) / 2 + "}", "Press 2 for expert"));
        }

        static void GameOverScreen(int height, int width, int score, int time) 
        {
            int[] numsSorted;
            KeepScore(score, out numsSorted);
            Console.WriteLine();
            Console.WriteLine("Highscores".PadLeft(width/2 + 5, ' '));
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0," + (width / 2 - 3) + "}...", i + 1);
                if (numsSorted[i] == score)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("{0,5}", numsSorted[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            //string  gameOver = String.Concat(Enumerable.Repeat("GAME OVER ", width / 10 + 5));
            //Console.WriteLine(gameOver);
            Console.WriteLine(String.Format("{0," + (width + "GAME OVER".Length) / 2 + "}", "GAME OVER"));
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine(String.Format("{0," + (width + "SCORE {0, 2}".Length) / 2 + "}", "SCORE {0}"), score);
            Console.WriteLine(String.Format("{0," + (width + "TIME  {0, 1}s".Length) / 2 + "}", "TIME {0}s"), (float)(time / 100) / 10f);
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + (width + "Press ENTER to return to menu".Length) / 2 + "}", "Press ENTER to return to menu"));
            Console.WriteLine("\n\n\n\n\n");
        }

        static void ScreenElements(int height, int width, out string[] lines, out int countLeft, out int countRight) 
        {
            lines = new string[height];
            string emptyLine = "";
            for (int i = 0; i < height - 1; i++)
            {
                lines[i] = emptyLine;
                lines[i] = lines[i].PadLeft(width, ' ');
            }
            countLeft = (width / 2) - 1;
            countRight = (width / 2) - 1;
            lines[height - 1] = emptyLine.PadLeft(countLeft, ' ') + "(0)" + emptyLine.PadRight(countRight, ' ');
        }

        static void KeepScore(int score, out int[] numsSorted)
        {
            //adjust file path
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string output = new string(path.ToCharArray().Reverse().ToArray());
            string result = output.Substring(output.IndexOf('\\') + 1);
            result = result.Substring(result.IndexOf('\\'));
            path = new string(result.ToCharArray().Reverse().ToArray());
            path = path + "highscores.txt";
            //
            string line;
            int[] nums = new int[11];
            numsSorted = new int[10];
            // Read the file line by line.
            System.IO.StreamReader fileRead = new System.IO.StreamReader(path);
            int counter = 0;
            while ((line = fileRead.ReadLine()) != null && (counter < 10))
            {
                nums[counter] = Convert.ToInt32(line);
                counter++;
            }
            fileRead.Close();
            //Sort scores
            nums[10] = score;
            SortNums(nums, out numsSorted);
            //Write into file
            System.IO.StreamWriter fileWrite = new System.IO.StreamWriter(path);
            for (int i = 0; i < 10; i++)
            {
                fileWrite.WriteLine(numsSorted[i]);
            }
            fileWrite.Close();
        }
        static void SortNums(int[] nums, out int[] sorted)
        {
            int n = nums.Length;
            sorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                int biggerNumsCount = 0;
                int equalNumsCount = 0;
                for (int j = 0; j < n; j++)
                {
                    biggerNumsCount = nums[i] < nums[j] ? biggerNumsCount = biggerNumsCount + 1 : biggerNumsCount;
                    equalNumsCount = nums[i] == nums[j] ? equalNumsCount = equalNumsCount + 1 : equalNumsCount;
                }
                for (int j = biggerNumsCount; j < biggerNumsCount + equalNumsCount; j++)
                {
                    sorted[j] = nums[i];
                }
            }
        }
    }
}
