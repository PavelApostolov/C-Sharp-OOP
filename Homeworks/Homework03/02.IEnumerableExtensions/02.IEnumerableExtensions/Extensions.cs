/*
 Problem 2. IEnumerable extensions
 Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static long SumE<T>(this IEnumerable<T> input)
        {
            long sum = 0;
            foreach (var val in input)
            {
                sum += long.Parse(val.ToString());
            }
            return sum;
        }

        public static long Product<T>(this IEnumerable<T> input)
        {
            long product = 1;
            foreach (var val in input)
            {
                product *= long.Parse(val.ToString());
            }
            return product;
        }

        public static long Min<T>(this IEnumerable<T> input)
        {
            long minValue = long.MaxValue;
            foreach (var value in input)
            {
                long currentVal = long.Parse(value.ToString());
                if (minValue > currentVal)
                    minValue = currentVal;
            }
            return minValue;
        }

        public static long Max<T>(this IEnumerable<T> input)
        {
            long maxValue = long.MinValue;
            foreach (var value in input)
            {
                long currentVal = long.Parse(value.ToString());
                if (maxValue < currentVal)
                    maxValue = currentVal;
            }
            return maxValue;
        }

        public static long Average<T>(this IEnumerable<T> input)
        {
            long count = 0;
            long sum = 0;
            foreach (var val in input)
            {
                count++;
                sum += long.Parse(val.ToString());
            }
            return sum / count;
        }
    }
}