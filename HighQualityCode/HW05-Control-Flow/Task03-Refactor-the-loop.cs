bool valueIsFound = false;

for (int i = 0; i < 100; i++) 
{
    Console.WriteLine(array[i]);

    if (i % 10 == 0)
    {
        if (array[i] == expectedValue) 
        {
            valueIsFound = true;
            break;
        }
    }
}
// More code here
if (valueIsFound)
{
    Console.WriteLine("Value Found");
}