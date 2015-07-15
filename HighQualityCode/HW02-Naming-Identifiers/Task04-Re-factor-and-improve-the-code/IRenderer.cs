namespace Task04_Re_factor_and_improve_the_code
{
    using System.Collections.Generic;

    public interface IRenderer
    {
        void OutputScoreBoard(List<Player> playerStats);

        void OutputBoard(char[,] playingBoard);

        void RenderNewGame(char[,] playingBoard);

        void OutputMessageOnExit();

        void OutputMessageOnWrongCommand();
    }
}