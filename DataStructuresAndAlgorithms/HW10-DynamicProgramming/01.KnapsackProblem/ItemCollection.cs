namespace _01.KnapsackProblem
{
    using System.Collections.Generic;

    public class ItemCollection
    {
        public ItemCollection()
        {
            this.Contents = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Contents { get; private set; }

        public int TotalValue { get; private set; }

        public int TotalWeight { get; private set; }

        public void AddItem(Item item, int quantity)
        {
            if (Contents.ContainsKey(item.Description))
            {
                Contents[item.Description] += quantity;
            }
            else
            {
                Contents[item.Description] = quantity;
            }

            TotalValue += quantity * item.Cost;
            TotalWeight += quantity * item.Weight;
        }
    }
}
