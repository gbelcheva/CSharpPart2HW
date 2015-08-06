namespace Task4_Compare_sort_algorithms
{
    using System;

    public class QuickSort<T> where T : IComparable
    {
        public T[] Sort(T[] inputArray)
        {
            return this.SortRecursively(inputArray, 0, inputArray.Length - 1);
        }

        private T[] SortRecursively(T[] inputArray, int lowIndex, int highIndex)
        {
            int k = lowIndex;
            int l = highIndex;
            T pivot = inputArray[(lowIndex + highIndex) / 2];

            while (k <= l)
            {
                while (inputArray[k].CompareTo(pivot) < 0)
                {
                    k++;
                }

                while (inputArray[l].CompareTo(pivot) > 0)
                {
                    l--;
                }

                if (k <= l)
                {
                    T holder = inputArray[k];
                    inputArray[k] = inputArray[l];
                    inputArray[l] = holder;
                    k++;
                    l--;
                }
            }

            if (l > lowIndex)
            {
                this.SortRecursively(inputArray, lowIndex, l);
            }

            if (k < highIndex)
            {
                this.SortRecursively(inputArray, k, highIndex);
            }

            return inputArray;
        }
    }
}
