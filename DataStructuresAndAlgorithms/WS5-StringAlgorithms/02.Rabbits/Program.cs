namespace _02.Rabbits
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


            var answers = Console.ReadLine().Split(new string[] { " ", "-1" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


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
