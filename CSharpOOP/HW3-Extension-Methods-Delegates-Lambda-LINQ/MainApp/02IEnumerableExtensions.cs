namespace MainApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class _02IEnumerableExtensions
    {
        public static T SumExt<T>(this IEnumerable<T> collection) 
        {
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }
        public static T ProductExt<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;
            foreach (var item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T MinExt<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.First();
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T MaxExt<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.First();
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static double AvgExt<T>(this IEnumerable<T> collection)
        {
            return (dynamic)collection.SumExt() / (double)collection.Count();
        }
    }
}
