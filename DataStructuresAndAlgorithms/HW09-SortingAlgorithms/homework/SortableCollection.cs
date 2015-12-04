namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var currentItem in this.items)
            {
                if (item.CompareTo(currentItem) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new MergeSorter<T>());

            var leftIndex = 0;
            var rightIndex = this.items.Count - 1;
            while (leftIndex <= rightIndex)
            {
                var middle = (rightIndex + leftIndex) / 2;
                if (this.items[middle].CompareTo(item) == 0)
                {
                    return true;
                }
                else if (this.items[middle].CompareTo(item) < 0)
                {
                    leftIndex = middle + 1;
                }
                else
                {
                    rightIndex = middle - 1;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < this.items.Count * 10; i++)
            {
                var firstIndex = random.Next(this.items.Count);
                var secondIndex = random.Next(this.items.Count);

                Swap(this.items, firstIndex, secondIndex);
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private void Swap(IList<T> collection, int first, int second)
        {
            var firstValue = collection[first];
            collection[first] = collection[second];
            collection[second] = firstValue;
        }
    }
}
