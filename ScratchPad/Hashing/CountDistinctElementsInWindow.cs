﻿using System;
using System.Collections.Generic;

namespace ScratchPadTests.Hashing
{
    public class CountDistinctElementsInWindow
    {
        public static void Count(int[] arr, int k)
        {
            if(k > arr.Length) throw new Exception();

            var set = new HashSet<int>();
            var dist_count = 0;

            for (var i = 0; i <= arr.Length - k; ++i)
            {
                for (var j = 0; j < k; ++j)
                {
                    if (set.Add(arr[i + j]))
                    {
                        dist_count++;
                    }
                }
                Console.Write(dist_count);
                Console.WriteLine();
                if (set.Remove(arr[i]))
                {
                    dist_count--;
                }
            }
        } 
    }
}