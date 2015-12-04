namespace _02.ProductsCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        private const int ProductsCount = 500000;
        private const int PriceSearches = 10000;

        public static void Main()
        {
            var products = new OrderedBag<Product>();

            Console.WriteLine("Adding Products");
            for (int i = 0; i < ProductsCount; i++)
            {
                products.Add(RandomGenerator.GetRandomProduct());

                if (i % 5000 == 0)
                {
                    Console.Write('+');
                }
            }

            var minPrice = 5M;
            var maxPrice = 10M;

            Console.WriteLine("\nGet 20 Products in the price range {0}-{1}", minPrice, maxPrice);
            for (int i = 0; i < PriceSearches; i++)
            {
                var foundProducts = GetProductsByPrice(products, minPrice, maxPrice);
                //Console.WriteLine(string.Join(", ", foundProducts));

                if (i % 1000 == 0)
                {
                    Console.Write('.');
                }
            }
        }

        private static List<Product> GetProductsByPrice(OrderedBag<Product> products, decimal minPrice, decimal maxPrice)
        {
            var result = products.Range(
                new Product("minProduct", minPrice),
                true,
                new Product("maxProduct", maxPrice),
                true)
                .Take(20)
                .ToList();

            return result;
        }
    }
}
