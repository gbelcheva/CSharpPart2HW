namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Linq;
    using System.Text;

    public class Shampoo : Product, IShampoo, IProduct
    {

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
        }
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            sb.Append(string.Format("  * Usage: {0}", this.Usage));
            return sb.ToString();
        }
    }
}
