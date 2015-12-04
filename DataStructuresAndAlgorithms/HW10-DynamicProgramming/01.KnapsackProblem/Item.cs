namespace _01.KnapsackProblem
{
    public class Item
    {
        public Item(string description, int weight, int cost, int quantity)
        {
            this.Description = description;
            this.Weight = weight;
            this.Cost = cost;
            this.Quantity = quantity;
        }

        public string Description { get; private set; }

        public int Quantity { get; private set; }

        public int Cost { get; private set; }

        public int Weight { get; private set; }
    }
}