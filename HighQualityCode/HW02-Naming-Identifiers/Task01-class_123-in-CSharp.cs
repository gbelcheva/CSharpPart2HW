public class Input
{
    private const int MaxCount = 6;

    public static void OutputTrueToConsole()
    {
        Input.InputHelper instance = new Input.InputHelper();

        instance.OutputVariable(true);
    }

    private class InputHelper
    {
        internal void OutputVariable(bool variable)
        {
            string variableAsString = variable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}