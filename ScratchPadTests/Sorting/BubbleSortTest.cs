using System;
using System.Collections.Generic;
using System.ComponentModel;
using ScratchPadTests.Sorting;

namespace ScratchPad.Sorting
{
    public class BubbleSortTest
    {
        public static void Run()
        {
            var list = new List<int>() {10, 3, 2, 1, 5, 6, 0, 4, 9};
            var sortedList = BubbleSort<int>.Sort(list.ToArray());

            foreach (var item in sortedList)
            {
                Console.Write(item + " ");
            }
        } 
    }
}