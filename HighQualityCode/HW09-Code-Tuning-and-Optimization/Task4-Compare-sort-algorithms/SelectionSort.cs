namespace Task4_Compare_sort_algorithms
{
    using System;

    public class SelectionSort<T> where T : IComparable
    {
        public T[] Sort(T[] inputArray)
        {
            int minPosition;
            T oldElement;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[minPosition]) < 0)
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    oldElement = inputArray[i];
                    inputArray[i] = inputArray[minPosition];
                    inputArray[minPosition] = oldElement;
                }
            }

            return inputArray;
        }
    }
}
