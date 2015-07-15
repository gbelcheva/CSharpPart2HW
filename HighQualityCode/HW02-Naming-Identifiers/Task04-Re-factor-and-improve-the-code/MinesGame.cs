namespace Task04_Re_factor_and_improve_the_code
{
    using System;

    public class MinesGame
    {
        public static void Main(string[] args)
        {
            var consoleRenderer = new MinesConsoleRenderer();
            var inputProvider = new MinesConsoleInputProvider();

            var newMinesEngine = new MinesEngine(consoleRenderer, inputProvider);

            newMinesEngine.StartMinesGame();
        }
    }
}