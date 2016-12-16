using System;
using System.Collections.Generic;
using ScratchPadTests.Heap;

namespace ScratchPad.Heap
{
    public class MergeKSortedArraysTest
    {
        public static void Run()
        {
            var sortedArrays = new List<List<int>>()
            {
                new List<int>()
                {
                    3,5,7
                },
                new List<int>()
                {
                    0,6
                },
                new List<int>()
                {
                    0,
                    6,
                    28
                }
            };
            var result = MergeKSortedArrays.MergeSortedFiles(sortedArrays);
            Console.WriteLine();
        }
    }
}