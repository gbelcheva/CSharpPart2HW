namespace _02.ProductsCollection
{
    using System;

    public class Product : IComparable<Product>
    {
        public override string ToString()
        {
            return string.Format("{0} [{1:F2}]", this.Name, this.Price);
        }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return (int)(this.Price - other.Price);
        }
    }
}
