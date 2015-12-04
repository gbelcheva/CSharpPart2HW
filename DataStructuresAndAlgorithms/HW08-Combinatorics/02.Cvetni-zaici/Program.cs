namespace _02.Cvetni_zaici
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            //var bgcoderLink = "http://bgcoder.com/Contests/Practice/Index/132#1"

            var n = int.Parse(Console.ReadLine());
            var answers = new int[n];
            for (int i = 0; i < n; i++)
            {
                answers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(answers);
            var minRabbitCount = 0;
            int j = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                var answer = answers[i];
                for (j = i; j < answer + i + 1; j++)
                {
                    if (j >= answers.Length ||
                        answers[j] != answer)
                    {
                        break;
                    }
                }

                i = --j;
                minRabbitCount += answer + 1;
            }

            Console.WriteLine(minRabbitCount);
        }
    }
}
