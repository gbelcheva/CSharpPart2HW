namespace Task04_Re_factor_and_improve_the_code
{
    using System;
    using System.Collections.Generic;

    public class MinesEngine
    {
        private IRenderer consoleRenderer;
        private IInputProvider inputProvider;

        public MinesEngine(IRenderer consoleRenderer, IInputProvider inputProvider) 
        {
            this.consoleRenderer = consoleRenderer;
            this.inputProvider = inputProvider;
        }

        public void StartMinesGame() {
            const int MaxFieldsNumber = 35;
            string command = string.Empty;
            char[,] playingBoard = CreatePlayingBoard();
            char[,] mines = PlaceMines();
            int openedFieldsNumber = 0;
            List<Player> topPlayers = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            bool isWinner = false;
            bool isGameOver = false;

            do
            {
                if (isNewGame)
                {
                    this.consoleRenderer.RenderNewGame(playingBoard);
                    isNewGame = false;
                }


                command = this.inputProvider.GetCommand();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playingBoard.GetLength(0) && column <= playingBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        this.consoleRenderer.OutputScoreBoard(topPlayers);
                        break;
                    case "restart":
                        playingBoard = CreatePlayingBoard();
                        mines = PlaceMines();
                        this.consoleRenderer.OutputBoard(playingBoard);
                        isGameOver = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        this.consoleRenderer.OutputMessageOnExit();
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                PlayTurn(playingBoard, mines, row, column);
                                openedFieldsNumber++;
                            }

                            if (MaxFieldsNumber == openedFieldsNumber)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                this.consoleRenderer.OutputBoard(playingBoard);
                            }
                        }
                        else
                        {
                            isGameOver = true;
                        }

                        break;
                    default:
                        this.consoleRenderer.OutputMessageOnWrongCommand();
                        break;
                }

                if (isGameOver)
                {
                    this.consoleRenderer.OutputBoard(mines);
                    string nickname = this.inputProvider.GetPlayerNicknameAtGameEnd(openedFieldsNumber, MaxFieldsNumber, isWinner);
                    Player finalScore = new Player(nickname, openedFieldsNumber);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(finalScore);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < finalScore.Points)
                            {
                                topPlayers.Insert(i, finalScore);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Player stats1, Player stats2) => stats2.Name.CompareTo(stats1.Name));
                    topPlayers.Sort((Player stats1, Player stats2) => stats2.Points.CompareTo(stats1.Points));
                    this.consoleRenderer.OutputScoreBoard(topPlayers);

                    playingBoard = CreatePlayingBoard();
                    mines = PlaceMines();
                    openedFieldsNumber = 0;
                    isGameOver = false;
                    isNewGame = true;
                }

                if (isWinner)
                {
                    string nickname = this.inputProvider.GetPlayerNicknameAtGameEnd(openedFieldsNumber, MaxFieldsNumber, isWinner);
                    this.consoleRenderer.OutputBoard(mines);
                    Player player = new Player(nickname, openedFieldsNumber);
                    topPlayers.Add(player);
                    this.consoleRenderer.OutputScoreBoard(topPlayers);
                    playingBoard = CreatePlayingBoard();
                    mines = PlaceMines();
                    openedFieldsNumber = 0;
                    isWinner = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            this.inputProvider.PauseExit();
        }
        
        private void PlayTurn(
            char[,] playingBoard,
            char[,] mines, 
            int row, 
            int column)
        {
            char numberOfMines = CountMines(mines, row, column);
            mines[row, column] = numberOfMines;
            playingBoard[row, column] = numberOfMines;
        }

        private char[,] CreatePlayingBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] playingBoard = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    playingBoard[i, j] = '?';
                }
            }

            return playingBoard;
        }

        private char[,] PlaceMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingBoard = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingBoard[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();

            while (minesList.Count < 15)
            {
                Random random = new Random();
                int minePosition = random.Next(50);
                if (!minesList.Contains(minePosition))
                {
                    minesList.Add(minePosition);
                }
            }

            foreach (int mine in minesList)
            {
                int row = mine % columns;
                int column = mine / columns;

                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingBoard[column, row - 1] = '*';
            }

            return playingBoard;
        }

        private char CountMines(char[,] board, int rows, int columns)
        {
            int counter = 0;
            int totalRows = board.GetLength(0);
            int totalColumns = board.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (board[rows - 1, columns] == '*')
                {
                    counter++;
                }
            }

            if (rows + 1 < totalRows)
            {
                if (board[rows + 1, columns] == '*')
                {
                    counter++;
                }
            }

            if (columns - 1 >= 0)
            {
                if (board[rows, columns - 1] == '*')
                {
                    counter++;
                }
            }

            if (columns + 1 < totalColumns)
            {
                if (board[rows, columns + 1] == '*')
                {
                    counter++;
                }
            }

            if ((rows - 1 >= 0) && (columns - 1 >= 0))
            {
                if (board[rows - 1, columns - 1] == '*')
                {
                    counter++;
                }
            }

            if ((rows - 1 >= 0) && (columns + 1 < totalColumns))
            {
                if (board[rows - 1, columns + 1] == '*')
                {
                    counter++;
                }
            }

            if ((rows + 1 < totalRows) && (columns - 1 >= 0))
            {
                if (board[rows + 1, columns - 1] == '*')
                {
                    counter++;
                }
            }

            if ((rows + 1 < totalRows) && (columns + 1 < totalColumns))
            {
                if (board[rows + 1, columns + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}