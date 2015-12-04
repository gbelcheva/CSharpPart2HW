using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OnlineMarket
{
    public class Product : IComparable<Product>
    {
        public string Name { get; private set; }

        public double Price { get; private set; }

        public string Type { get; private set; }

        public static Product Parse(IList<string> input)
        {
            return new Product()
            {
                Name = input[0],
                Price = double.Parse(input[1]),
                Type = input[2]
            };
        }

        public int CompareTo(Product other)
        {
            var result = this.Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Type.CompareTo(other.Type);
                }
            }
            return result;
        }

        public override string ToString()
        {
            if (Price.ToString().Split('.').Length > 1)
            {
                var decimalPlaces = Price.ToString().Split('.')[1].Length;
                return string.Format("{0}({1})", this.Name, Math.Round(this.Price, decimalPlaces));
            }

            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }

    public class Command
    {
        public string Name { get; set; }

        public IList<string> Arguments { get; set; }

        public static Command Parse(string[] input)
        {
            var argumentsList = new List<string>();
            var name = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                argumentsList.Add(input[i]);
            }

            return new Command()
            {
                Name = name,
                Arguments = argumentsList
            };
        }
    }

    public class Market
    {
        private ISet<string> productNames;
        private IDictionary<string, SortedSet<Product>> productsByType;
        private IDictionary<double, SortedSet<Product>> productsByPrice;
        private SortedSet<double> productPrices;

        public Market()
        {
            this.productNames = new HashSet<string>();
            this.productsByType = new Dictionary<string, SortedSet<Product>>();
            this.productsByPrice = new SortedDictionary<double, SortedSet<Product>>();
            this.productPrices = new SortedSet<double>();
        }

        public string Add(Product product)
        {
            if (productNames.Contains(product.Name))
            {
                return string.Format("Error: Product {0} already exists", product.Name);
            }

            this.productNames.Add(product.Name);

            if (!productsByType.ContainsKey(product.Type))
            {
                this.productsByType[product.Type] = new SortedSet<Product>();
            }

            this.productsByType[product.Type].Add(product);


            this.productPrices.Add(product.Price);

            if (!productsByPrice.ContainsKey(product.Price))
            {
                this.productsByPrice[product.Price] = new SortedSet<Product>();
            }

            this.productsByPrice[product.Price].Add(product);

            return string.Format("Ok: Product {0} added successfully", product.Name);
        }

        public string FilterByType(string type)
        {
            if (!this.productsByType.ContainsKey(type))
            {
                return string.Format("Error: Type {0} does not exists", type);
            }

            var foundProducts = productsByType[type].Take(10);

            return string.Format("Ok: {0}", string.Join(", ", foundProducts));
        }

        public string FilterByPrice(double minPrice, double maxPrice)
        {
            var prices = this.productPrices.GetViewBetween(minPrice, maxPrice);

            string result = string.Empty;
            var taken = 0;
            var foundProducts = new SortedSet<Product>();
            foreach (var price in prices)
            {
                foreach (var product in this.productsByPrice[price])
                {
                    if (taken == 10)
                    {
                        break;
                    }

                    foundProducts.Add(product);
                    taken++;
                }
            }

            return string.Format("Ok: {0}", string.Join(", ", foundProducts)); ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();

            StringBuilder result = new StringBuilder();
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "end")
            {
                var command = Command.Parse(input);
                switch (command.Name)
                {
                    case "add":
                        var product = Product.Parse(command.Arguments);
                        result.AppendLine(market.Add(product));
                        break;
                    case "filter":
                        switch (command.Arguments[1])
                        {
                            case "type":
                                var type = command.Arguments[2];
                                result.AppendLine(market.FilterByType(type));
                                break;
                            case "price":
                                double minPrice = 0;
                                double maxPrice = double.MaxValue;

                                if (command.Arguments.Count > 4)
                                {
                                    minPrice = double.Parse(command.Arguments[3]);
                                    maxPrice = double.Parse(command.Arguments[5]);
                                }
                                else if (command.Arguments[2] == "from")
                                {
                                    minPrice = double.Parse(command.Arguments[3]);
                                }
                                else if (command.Arguments[2] == "to")
                                {
                                    maxPrice = double.Parse(command.Arguments[3]);
                                }

                                result.AppendLine(market.FilterByPrice(minPrice, maxPrice));
                                break;
                            default:
                                throw new InvalidOperationException();
                        }

                        break;
                    default:
                        throw new InvalidOperationException();
                }

                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.Write(result);
        }
    }
}
