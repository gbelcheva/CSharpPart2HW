namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart : IShoppingCart
    {
        private readonly List<IProduct> shoppingCartList;

        public ShoppingCart()
        {
            this.shoppingCartList = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            shoppingCartList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            shoppingCartList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return shoppingCartList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return shoppingCartList.Sum(d => d.Price);
        }
    }
}
