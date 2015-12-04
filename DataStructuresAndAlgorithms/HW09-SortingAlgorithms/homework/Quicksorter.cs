namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private IList<T> QuickSort(IList<T> collection, int lowIndex, int highIndex)
        {
            int k = lowIndex;
            int l = highIndex;
            T pivot = collection[(lowIndex + highIndex) / 2];

            while (k <= l)
            {
                while (collection[k].CompareTo(pivot) < 0)
                {
                    k++;
                }

                while (collection[l].CompareTo(pivot) > 0)
                {
                    l--;
                }

                if (k <= l)
                {
                    T holder = collection[k];
                    collection[k] = collection[l];
                    collection[l] = holder;
                    k++;
                    l--;
                }
            }

            if (l > lowIndex)
            {
                this.QuickSort(collection, lowIndex, l);
            }

            if (k < highIndex)
            {
                this.QuickSort(collection, k, highIndex);
            }

            return collection;
        }
    }
}
