namespace _02.CardGame
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            int[,] subintervalProducts = new int[numbers.Length, numbers.Length];

            for (int intervalLength = 3; intervalLength <= numbers.Length; intervalLength++)
            {
                for (int leftIndex = 0; leftIndex <= numbers.Length - intervalLength; leftIndex++)
                {
                    var rightIndex = leftIndex + intervalLength - 1;
                    for (int currentIndex = leftIndex + 1; currentIndex < rightIndex; currentIndex++)
                    {
                        int currentProduct = subintervalProducts[leftIndex, currentIndex] + subintervalProducts[currentIndex, rightIndex] +
                            numbers[currentIndex] * (numbers[leftIndex] + numbers[rightIndex]);

                        if (subintervalProducts[leftIndex, rightIndex] < currentProduct)
                        {
                            subintervalProducts[leftIndex, rightIndex] = currentProduct;
                        }
                    }

                }
            }

            Console.WriteLine(subintervalProducts[0, numbers.Length - 1]);
        }
    }
}
