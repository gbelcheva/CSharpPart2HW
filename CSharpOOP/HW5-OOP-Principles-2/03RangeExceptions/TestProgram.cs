namespace _03RangeExceptions
{
    using System;

    class TestProgram
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid number range", 1, 100);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex);
                throw new InvalidRangeException<DateTime>("Invalid dates range", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }


            //throw new InvalidRangeException<int>("Invalid number range", 1, 100);
            //throw new InvalidRangeException<DateTime>("Invalid dates range", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
        }
    }
}
