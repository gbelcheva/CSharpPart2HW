namespace Task4_Compare_sort_algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InsertionSort<T> where T : IComparable
    {
        public T[] Sort(T[] inputArray) 
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1].CompareTo(inputArray[j]) > 0)
                    {
                        T oldElement = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = oldElement;
                    }
                }
            }

            return inputArray;
        }
    }
}
