namespace Methods
{
    using System;

    /// <summary>
    /// A collection of unrelated methods and a method to test them.
    /// </summary>
    public class Methods
    {
        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToWord(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(FormatNumber(1.3, "f"));
            Console.WriteLine(FormatNumber(0.75, "%"));
            Console.WriteLine(FormatNumber(2.30, "r"));

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            Console.WriteLine(CalcDistance(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + CheckIfHorizontalLine(y1, y2));
            Console.WriteLine("Vertical? " + CheckIfVerticalLine(x1, x2));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
        }

        /// <summary>
        /// Calculates the area of a triangle using Heron's formula.
        /// </summary>
        /// <param name="a">First side of the triangle.</param>
        /// <param name="b">Second side of the triangle.</param>
        /// <param name="c">Third side of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        /// <exception cref="ArgumentException">Thrown when any of the triangle sides are not positive or they do not form a triangle.</exception>
        private static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (a + b <= c || c + a <= b || b + c <= a)
            {
                throw new ArgumentException("Sides do not form a triangle.");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        /// <summary>
        /// Converts a digit to a word representation.
        /// </summary>
        /// <param name="digit">The digit to be converted.</param>
        /// <returns>Word representation of the digit.</returns>
        /// <exception cref="ArgumentException">Thrown when a non digit input is passed.</exception>
        private static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Input is not a digit.");
            }
        }

        /// <summary>
        /// Finds the largest number from the passed number parameters.
        /// </summary>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Largest number.</returns>
        /// <exception cref="ArgumentException">Thrown when no numbers are passed.</exception>
        private static int FindMaxNumber(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("No input numbers.");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[0])
                {
                    numbers[0] = numbers[i];
                }
            }

            return numbers[0];
        }

        /// <summary>
        /// Formats a number to a string representation, given a predefined format.
        /// </summary>
        /// <param name="number">The number to be formatted.</param>
        /// <param name="format">A predefined format.</param>
        /// <returns>Formatted string representation of original number.</returns>
        /// <exception cref="ArgumentException">Thrown when the input is not of a numeric type.</exception>
        private static string FormatNumber(object number, string format)
        {
            if (!(number is sbyte ||
            number is byte ||
            number is short ||
            number is ushort ||
            number is int ||
            number is uint ||
            number is long ||
            number is ulong ||
            number is float ||
            number is double ||
            number is decimal))
            {
                throw new ArgumentException("Input is not a number.");
            }

            string formattedNumber = string.Empty;

            if (format == "f")
            {
                formattedNumber = string.Format("{0:f2}", number);
            }
            else if (format == "%")
            {
                formattedNumber = string.Format("{0:p0}", number);
            }
            else if (format == "r")
            {
                formattedNumber = string.Format("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Unknown format.");
            }

            return formattedNumber;
        }

        /// <summary>
        /// Calculates the distance between two 2D points.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <returns>The distance between the two points.</returns>
        private static double CalcDistance(
            double x1,
            double y1,
            double x2,
            double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        /// <summary>
        /// Checks if two 2D points lie on a horizontal line.
        /// </summary>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <returns>True if the points lie on a horizontal line, false otherwise.</returns>
        private static bool CheckIfHorizontalLine(
            double y1,
            double y2)
        {
            return y1 == y2;
        }

        /// <summary>
        /// Checks if two 2D points lie on a vertical line.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <returns>True if the points lie on a vertical line, false otherwise.</returns>
        private static bool CheckIfVerticalLine(
            double x1,
            double x2)
        {
            return x1 == x2;
        }
    }
}
