namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            MergeSort(collection, 0, collection.Count - 1);
        }

        private void MergeSort(IList<T> collection, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                var middle = (minIndex + maxIndex) / 2;
                MergeSort(collection, minIndex, middle);
                MergeSort(collection, middle + 1, maxIndex);
                
                var currentIndexLeft = minIndex;
                var currentIndexRight = middle + 1;
                while (currentIndexLeft <= middle)
                {
                    if (collection[currentIndexLeft].CompareTo(collection[currentIndexRight]) > 0)
                    {
                        Swap(collection, currentIndexLeft, currentIndexRight);

                        while (currentIndexRight < maxIndex && collection[currentIndexRight].CompareTo(collection[currentIndexRight + 1]) > 0)
                        {
                            Swap(collection, currentIndexRight, currentIndexRight + 1);
                            ++currentIndexRight;
                        }

                        currentIndexRight = middle + 1;
                    }
                    ++currentIndexLeft;
                }

                while (currentIndexLeft < maxIndex && collection[currentIndexLeft].CompareTo(collection[currentIndexLeft + 1]) > 0)
                {
                    Swap(collection, currentIndexLeft, currentIndexLeft + 1);
                    ++currentIndexLeft;
                }
            }
        }

        private void Swap(IList<T> collection, int first, int second)
        {
            var firstValue = collection[first];
            collection[first] = collection[second];
            collection[second] = firstValue;
        }
    }
}
