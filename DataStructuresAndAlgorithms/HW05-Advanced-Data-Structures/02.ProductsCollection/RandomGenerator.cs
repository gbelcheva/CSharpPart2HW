namespace _02.ProductsCollection
{
    using System;
    using System.Text;

    public static class RandomGenerator
    {
        private const string Alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456790";
        private static Random random = new Random();

        public static int GetRandomNumber(int min = int.MinValue, int max = int.MaxValue - 1)
        {
            return random.Next(min, max + 1);
        }

        public static string GetRandomString(int minLength = 0, int maxLength = int.MaxValue - 1)
        {
            int length = GetRandomNumber(minLength, maxLength);

            var sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var randomLetter = Alphabet[GetRandomNumber(0, Alphabet.Length - 1)];
                sb.Append(randomLetter);
            }

            return sb.ToString();
        }

        public static DateTime GetRandomDate(DateTime? after = null, DateTime? before = null)
        {
            var minDate = after ?? new DateTime(1990, 1, 1);
            var maxDate = before ?? new DateTime(2050, 1, 1);

            int range = (maxDate - minDate).Seconds;

            return minDate.AddSeconds(GetRandomNumber(range));
        }

        public static Product GetRandomProduct()
        {
            var name = GetRandomString(5, 10);
            decimal price = GetRandomNumber(0, 50) / 0.23M + 0.50M;

            return new Product(name, price);
        }
    }
}
