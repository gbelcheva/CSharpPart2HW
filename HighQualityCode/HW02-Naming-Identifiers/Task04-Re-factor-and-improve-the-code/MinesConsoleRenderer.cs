namespace Task04_Re_factor_and_improve_the_code
{
    using System;
    using System.Collections.Generic;

    public class MinesConsoleRenderer : IRenderer
    {
        public void OutputScoreBoard(List<Player> playerStats)
        {
            Console.WriteLine("\nScore:");
            if (playerStats.Count > 0)
            {
                for (int i = 0; i < playerStats.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} fields",
                        i + 1, 
                        playerStats[i].Name, 
                        playerStats[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No recorded scores.\n");
            }
        }

        public void OutputBoard(char[,] playingBoard)
        {
            int boardRows = playingBoard.GetLength(0);
            int boardColumns = playingBoard.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write(string.Format("{0} ", playingBoard[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public void RenderNewGame(char[,]  playingBoard)
        {
            Console.WriteLine("Lets play Mines. Try to step on fields while avoiding the mines." +
                    " Show high scores with command 'top', start new game with 'restart', quit game with 'exit'!");
            OutputBoard(playingBoard);
        }

        public void OutputMessageOnExit() 
        {
            Console.WriteLine("Goodbye!");
        }

        public void OutputMessageOnWrongCommand() 
        {
            Console.WriteLine("\nWrong command.\n");
        }
    }
}