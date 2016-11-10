/*
 Problem 2. IEnumerable extensions
 Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */
namespace IEnumerable_extensions
{
    using System;
    using System.Linq;

    class StartProgram
    {
        static void Main()
        {
            int[] ints = new int[5];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i + 1;
            }
            Console.WriteLine(ints.Sum());
            Console.WriteLine(ints.Product());
            Console.WriteLine(ints.Average());
            Console.WriteLine(ints.Max());
            Console.WriteLine(ints.Min());
        }
    }
}