namespace Cosmetics.Products
{
    using System;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public abstract class Product : IProduct
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private const int MinBrandNameLength = 2;
        private const int MaxBrandNameLength = 10;
        private string name;
        private string brandName;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinNameLength, MaxNameLength));
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product name"));
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brandName; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxBrandNameLength, MinBrandNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandNameLength, MaxBrandNameLength));
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product brand"));
                this.brandName = value;
            }
        }

        public virtual decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", this.brandName, this.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", this.Price));
            sb.Append(string.Format("  * For gender: {0}", this.Gender));
            return sb.ToString();
        }
    }
}
