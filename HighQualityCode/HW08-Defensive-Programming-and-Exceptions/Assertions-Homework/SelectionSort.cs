namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class SelectionSortAlgorithm
    {
        public void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = this.FindMinElementIndex(arr, index, arr.Length - 1);
                this.Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(arr.OrderBy(element => element).ToArray().SequenceEqual(arr), "Selection sort algorithm is not working properly.");
        }

        private int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");
            Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "Start index is out of range.");
            Debug.Assert(0 <= endIndex && endIndex <= arr.Length - 1, "End index is out of range.");
            Debug.Assert(startIndex <= endIndex, "Start index is larger than end index.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "First swap parameter is null.");
            Debug.Assert(y != null, "Second swap parameter is null.");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
