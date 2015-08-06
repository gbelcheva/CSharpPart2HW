using System;
using Assertions_Homework;

public class AssertionsHomework
{
    public static void Main()
    {
        BinarySearchAlgoruthm binarySearch = new BinarySearchAlgoruthm();
        SelectionSortAlgorithm selectionSord = new SelectionSortAlgorithm();

        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        selectionSord.SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        selectionSord.SelectionSort(new int[0]); // Test sorting empty array
        selectionSord.SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(binarySearch.BinarySearch(arr, -1000));
        Console.WriteLine(binarySearch.BinarySearch(arr, 0));
        Console.WriteLine(binarySearch.BinarySearch(arr, 17));
        Console.WriteLine(binarySearch.BinarySearch(arr, 10));
        Console.WriteLine(binarySearch.BinarySearch(arr, 1000));
    }
}
