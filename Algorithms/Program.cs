using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SearchAlgorithms.BinarySearch(GenerateIntArray(10000), 999);
            Console.WriteLine($"Count: {result.count} \nIndex: {result.index}");
        }

        static int[] GenerateIntArray(int size)
        {
            var array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = i + 1;

            return array;
        }
    }
}
