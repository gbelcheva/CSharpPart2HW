namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int MinIngredientNameLength = 4;
        private const int MaxIngredientNameLength = 12;
        private List<string> ingredient;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredientsList)
            : base(name, brand, price, gender)
        {
            this.ingredient = new List<string>();
            this.Ingredient = ingredientsList;
            
        }

        public IList<string> Ingredient
        {
            get { return this.ingredient; }
            set
            {
                foreach (var ingredient in value)
                {
                    Validator.CheckIfStringLengthIsValid(ingredient, MaxIngredientNameLength, MinIngredientNameLength, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Category name"));
                    Validator.CheckIfStringIsNullOrEmpty(ingredient, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Ingredient"));
                    this.ingredient.Add(ingredient);
                }
            }
        }
        public string Ingredients
        {
            get { return string.Join(", ", this.Ingredient); }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.Append(string.Format("  * Ingredients: {0}", this.Ingredients));
            return sb.ToString();
        }
    }
}
