namespace Task04_Re_factor_and_improve_the_code
{
    public interface IInputProvider
    {
        string GetCommand();

        string GetPlayerNicknameAtGameEnd(int openedFieldsNumber, int MaxFieldsNumber, bool isWinner);

        void PauseExit();
    }
}