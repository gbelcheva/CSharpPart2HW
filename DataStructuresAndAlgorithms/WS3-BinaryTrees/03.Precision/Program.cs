using System;

namespace _03.Precision
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxDenominator = int.Parse(Console.ReadLine());
            var number = Console.ReadLine();

            Console.WriteLine(DoubleToFraction(number, maxDenominator));
        }

        public static string DoubleToFraction(string number, int maxDenominator, double epsilon = 0.0001, int maxIterations = 20)
        {
            int decimalDigits = number.Split(new char[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries)[1].Length;
            double num = double.Parse(number);
            double denominator = 1;
            double z = num;
            double n = 1;
            
            double decimalNumberPart = num - Math.Truncate(num);
            double oldDenominator = 0;

            while (true)
            {
                var oldOldDenominator = oldDenominator;
                oldDenominator = denominator;

                z = 1 / (z - (int)z);
                denominator = oldDenominator * (int)z + oldOldDenominator;

                if (Math.Abs(z - 1) < 0.001)
                {
                    break;
                }

                if (denominator > maxDenominator)
                {
                    denominator = oldDenominator;
                    break;
                }
            }
            n = (int)(decimalNumberPart * denominator + 0.5);
            string approximation = (n / denominator).ToString("N" + decimalDigits);
            int digitsCount = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '.' ||
                    number[i] == ',')
                {
                    continue;
                }
                if (number[i] != approximation[i])
                {
                    break;
                }

                digitsCount++;
            }

            return string.Format("{0}/{1} \n{2}",
                                 n.ToString(),
                                 denominator.ToString(),
                                 digitsCount
                                );
        }
    }
}
