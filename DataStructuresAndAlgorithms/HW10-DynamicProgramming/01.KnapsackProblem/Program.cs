namespace _01.KnapsackProblem
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var items = new List<Item>()
            {
                new Item("Beer", 3, 2, 1),
                new Item("Vodka", 8, 12, 1),
                new Item("Cheese", 4, 5, 1),
                new Item("Nuts", 1, 4, 1),
                new Item("Ham", 2, 3, 1),
                new Item("Whiskey", 8, 13, 1)
            };

            int capacity = 10;

            ItemCollection[] itemCollection = new ItemCollection[capacity + 1];

            for (int i = 0; i <= capacity; i++) itemCollection[i] = new ItemCollection();

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = capacity; j >= 0; j--)
                {
                    if (j >= items[i].Weight)
                    {
                        int quantity = Math.Min(items[i].Quantity, j / items[i].Weight);
                        for (int k = 1; k <= quantity; k++)
                        {
                            ItemCollection lighterCollection = itemCollection[j - k * items[i].Weight];
                            int testValue = lighterCollection.TotalValue + k * items[i].Cost;
                            if (testValue > itemCollection[j].TotalValue) (itemCollection[j] = lighterCollection.Copy()).AddItem(items[i], k);
                        }
                    }
                }
            }

            Console.WriteLine("\nKnapsack Capacity: {0}\nFilled Weight: {1}\nFilled Value: {2}", capacity, itemCollection[capacity].TotalWeight, itemCollection[capacity].TotalValue);

            Console.WriteLine("\nContents: ");
            foreach (var item in itemCollection[capacity].Contents)
            {
                Console.Write("{0} ({1})\n",item.Key, item.Value);
            }
        }
    }
}
