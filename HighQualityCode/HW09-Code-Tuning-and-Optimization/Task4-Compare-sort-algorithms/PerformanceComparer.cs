namespace Task4_Compare_sort_algorithms
{
    using System;
    using System.Diagnostics;

    public class PerformanceComparer
    {
        public const int IterationsCount = 100000;
        private static readonly int[] RandomInteger = new int[] { 5, 8, 5, 9, 1 };
        private static readonly double[] RandomDouble = new double[] { 5.8, 9.7, 1.2, 6.3, 8.8 };
        private static readonly string[] RandomString = new string[] { "aaa", "ggg", "ttt", "bbb", "rrr" };
        private static readonly int[] SortedInteger = new int[] { 1, 5, 5, 8, 9 };
        private static readonly double[] SortedDouble = new double[] { 1.2, 5.8, 6.3, 8.8, 9.7 };
        private static readonly string[] SortedString = new string[] { "aaa", "bbb", "ggg", "rrr", "ttt" };
        private static readonly int[] ReversedInteger = new int[] { 9, 8, 5, 5, 1 };
        private static readonly double[] ReversedDouble = new double[] { 9.7, 8.8, 6.3, 5.8, 1.2 };
        private static readonly string[] ReversedString = new string[] { "ttt", "rrr", "ggg", "bbb", "aaa" };
        private static readonly Stopwatch StopWatch = new Stopwatch();

        public TimeSpan TimeExecution(Algorithms algorithm, Values value, Cases c) 
        {
            dynamic val;
            TimeSpan executionTime;
            dynamic insertionSort;
            dynamic selectionSort;
            dynamic quickSort;

            switch (value)
            {
                case Values.intValue:
                    insertionSort = new InsertionSort<int>();
                    selectionSort = new SelectionSort<int>();
                    quickSort = new QuickSort<int>();

                    switch (c)
                    {
                        case Cases.randomValues:
                            val = RandomInteger;
                            break;
                        case Cases.sortedValues:
                            val = SortedInteger;
                            break;
                        case Cases.reverseSortedValues:
                            val = ReversedInteger;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("The case " + c + " is not a valid case.");
                    }

                    break;
                case Values.doubleValue:
                    insertionSort = new InsertionSort<double>();
                    selectionSort = new SelectionSort<double>();
                    quickSort = new QuickSort<double>();

                    switch (c)
                    {
                        case Cases.randomValues:
                            val = RandomDouble;
                            break;
                        case Cases.sortedValues:
                            val = SortedDouble;
                            break;
                        case Cases.reverseSortedValues:
                            val = ReversedDouble;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("The case " + c + " is not a valid case.");
                    }

                    break;
                case Values.stringValue:
                    insertionSort = new InsertionSort<string>();
                    selectionSort = new SelectionSort<string>();
                    quickSort = new QuickSort<string>();

                    switch (c)
                    {
                        case Cases.randomValues:
                            val = RandomString;
                            break;
                        case Cases.sortedValues:
                            val = SortedString;
                            break;
                        case Cases.reverseSortedValues:
                            val = ReversedString;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("The case " + c + " is not a valid case.");
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException("The value " + value + " is not a valid value.");
            }

            StopWatch.Start();

            switch (algorithm)
            {
                case Algorithms.insertionSort:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        insertionSort.Sort(val);
                    }

                    break;
                case Algorithms.selectionSort:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        selectionSort.Sort(val);
                    }

                    break;
                case Algorithms.quickSort:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        quickSort.Sort(val);
                    }

                    break;
                default: throw new InvalidOperationException("The passed algorithm " + algorithm + " is not valid.");
            }

            StopWatch.Stop();

            executionTime = StopWatch.Elapsed;

            return executionTime;
        }
    }
}
