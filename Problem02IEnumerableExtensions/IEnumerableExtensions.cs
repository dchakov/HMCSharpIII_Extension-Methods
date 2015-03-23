//Problem 2. IEnumerable extensions• 
//Implement a set of extension methods for  IEnumerable<T>  that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> collection)
        {
            dynamic result = default(T);
            foreach (var item in collection)
            {
                result += item;
            }
            return result;
        }
        public static T ProductOfCollection<T>(this IEnumerable<T> collection)
        {
            dynamic result = (dynamic)1;
            foreach (var item in collection)
            {
                result *= item;
            }
            return result;
        }
        public static T MinOfCollection<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            T min = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T MaxOfCollection<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }
        public static double AverageOfCollection<T>(this IEnumerable<T> collection)
            where T:IConvertible
        {
           return (dynamic)collection.SumOfCollection()/ (double)collection.Count();
        }

    }
}
