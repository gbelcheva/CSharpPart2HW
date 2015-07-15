namespace Task04_Re_factor_and_improve_the_code
{
    using System;
    using System.Linq;

    class MinesConsoleInputProvider : IInputProvider
    {
        public string GetCommand()
        {
            Console.Write("Input row and column: ");

            return Console.ReadLine().Trim();
        }

        public string GetPlayerNicknameAtGameEnd(int openedFieldsNumber, int MaxFieldsNumber, bool isWinner)
        {
            if (isWinner)
            {
                Console.WriteLine("\nCongratilations! You stepped on all " + MaxFieldsNumber + " fields without stepping on a mine.");
                Console.WriteLine("Input nickname: ");
            }
            else
            {
                Console.Write(
                        "\nGame over, you stepped on a mine! You managed to score {0} points. " +
                        "Input nickname: ",
                        openedFieldsNumber);
            }

            return Console.ReadLine();
        }

        public void PauseExit() {
            Console.Read();
        }
    }
}
