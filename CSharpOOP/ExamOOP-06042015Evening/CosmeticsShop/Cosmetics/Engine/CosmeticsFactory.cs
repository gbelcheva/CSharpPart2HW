namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using System;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        private IList<string> categoryNames;

        public CosmeticsFactory()
        {
            this.categoryNames = new List<string>();
        }

        public ICategory CreateCategory(string name)
        {
            if (!this.categoryNames.Contains(name))
            {
                this.categoryNames.Add(name);
                return new Category(name);
            }
            return null;
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {

            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            return new Toothpaste(name, brand, price, gender, ingredients);
        }
        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
        public void AddToCategory(ICategory categoryName, IProduct productName)
        {
            categoryName.AddCosmetics(productName);
        }

        public void RemoveFromCategory(ICategory categoryName, IProduct productName)
        {
            categoryName.RemoveCosmetics(productName);

        }
        public void ShowCategory(ICategory categoryName)
        {
            Console.WriteLine(categoryName.Print()); // check if category exists?
        }


        public void AddToShoppingCart(IProduct productName, IShoppingCart shoppingCart)
        {
            if (productName != null)
            {
                shoppingCart.AddProduct(productName);
            }
        }
        public void RemoveFromShoppingCart(IProduct productName, IShoppingCart shoppingCart)
        {
            if (productName != null)
            {
                ShoppingCart().RemoveProduct(productName);
            }
        }
        public decimal TotalPrice()
        {
            return ShoppingCart().TotalPrice();
        }


        
    }
}
