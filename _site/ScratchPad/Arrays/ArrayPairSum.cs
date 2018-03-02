using System;
using System.Collections.Generic;

namespace ScratchPadTests.Arrays
{
    public class ArrayPairSum
    {
        public static void FindPairs(int[] arr, int k)
        {
            var bag = new HashSet<int>();

            foreach (var i in arr)
            {
                if (bag.Contains(k-i))
                {
                    if((2 * i != k))
                    Console.WriteLine(i + "," + (k - i));
                }
                else
                {
                    bag.Add(i);
                }
            }
        }
    }
}