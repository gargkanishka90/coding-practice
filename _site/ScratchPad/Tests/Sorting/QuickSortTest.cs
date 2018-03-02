using System.Collections.Generic;
using NUnit.Framework;
using ScratchPadTests.Sorting;

namespace ScratchPad
{
    public class QuickSortTest
    {
        [Test]
        public static void Run()
        {
            var list1 = new List<int>() { 10, 3, 2, 1, 5, 6, 0, 4, 9 };
            var list = QuickSort<int>.Sort(list1.ToArray(), 0, list1.Count-1);
            Assert.AreEqual(0, list[0]);
            Assert.AreEqual(1, list[1]);
            Assert.AreEqual(9, list[7]);
            Assert.AreEqual(10, list[8]);
        }
    }
}