using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class SearchAlgorithms
    {
        public static (int index, int count) BinarySearch(int[] storage, int element)
        { 
            if(storage.Length == 0)
                throw new Exception();

            var count = 0;
            var min = 0;
            var max = storage.Length - 1;
            while (min <= max)
            {
                count++;
                var middle = (min + max) / 2;
                var item = storage[middle];
                    
                if (item == element)
                    return (middle, count);

                if (element > item)
                    min = middle + 1;
                else
                    max = middle - 1;
            }

            return (0, 0);
        }
    }
}