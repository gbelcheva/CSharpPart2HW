namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Category : ICategory
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 15;
        private string name;
        private readonly List<IProduct> productCategory;

        public Category(string name)
        {

            this.Name = name;
            this.productCategory = new List<IProduct>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinNameLength, MaxNameLength));
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Category name"));
                this.name = value;
            }
        }

        public List<IProduct> ProductCategory
        {
            get
            {
                return new List<IProduct>(this.productCategory.OrderBy(p => p.Brand).ThenByDescending(p => p.Price));
            }
        }
        public void AddCosmetics(IProduct cosmetics)
        {
            this.productCategory.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (this.ProductCategory.Contains(cosmetics))
            {
                this.productCategory.Remove(cosmetics);
            }
            else
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            if (this.ProductCategory.Count == 1)
            {
                sb.Append(string.Format("{0} category - {1} product in total", this.Name, this.ProductCategory.Count));
                
            }
            else
            {
                sb.Append(string.Format("{0} category - {1} products in total", this.Name, this.ProductCategory.Count));
            }
            foreach (var item in this.ProductCategory)
            {
                sb.AppendLine();
                sb.Append(item.Print());
            }
            return sb.ToString();
        }
    }
}
