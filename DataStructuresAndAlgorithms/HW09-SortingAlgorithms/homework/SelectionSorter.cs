namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            T smallest;
            int smallestIndex = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                smallest = collection[i];
                for (int j = i; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(smallest) < 0)
                    {
                        smallest = collection[j];
                        smallestIndex = j;
                    }
                }

                collection[smallestIndex] = collection[i];
                collection[i] = smallest;
            }
        }
    }
}
