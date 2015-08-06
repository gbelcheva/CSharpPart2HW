namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class BinarySearchAlgoruthm
    {
        public int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");
            Debug.Assert(value != null, "Searched value is null.");

            return this.BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");
            Debug.Assert(value != null, "Searched value is null.");
            Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "Start index is out of range.");
            Debug.Assert(0 <= endIndex && endIndex <= arr.Length - 1, "End index is out of range.");
            Debug.Assert(startIndex <= endIndex, "Start index is larger than end index.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;

                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(!Array.Find(arr, element => element.Equals(value)).Equals(value), "Binary search algorithm did not find existing element.");
            
            return -1;
        }
    }
}
