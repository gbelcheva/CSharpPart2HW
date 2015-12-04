namespace _03.Robo_Zombi_Kamila
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //var bgcoderLink = "http://bgcoder.com/Contests/Practice/Index/132#9"

            int n = int.Parse(Console.ReadLine());
            var distances = new long[n];
            int index = 0;
            while (index < n)
            {
                var input = Console.ReadLine();
                var inputParts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputParts.Length < 2)
                {
                    continue;
                }
                distances[index] = Math.Abs(Int64.Parse(inputParts[0])) + Math.Abs((Int64.Parse(inputParts[1])));
                index++;
            }

            ulong mask = 1;
            ulong numSingleDistanceRepeats = mask << (n - 1);
            ulong totalRope = 0;
            for (int i = 0; i < n; i++)
            {
                totalRope += ((ulong)distances[i] * numSingleDistanceRepeats);
            }

            Console.WriteLine(totalRope);
        }
    }

}
