using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;
using ScratchPadTests.Sorting;

namespace ScratchPad.Sorting
{
    [TestFixture]
    public class BubbleSortTest
    {
        [Test]
        public static void Run()
        {
            var list = new List<int>() {10, 3, 2, 1, 5, 6, 0, 4, 9};
            var sortedList = BubbleSort<int>.Sort(list.ToArray());
            Assert.AreEqual(0, sortedList[0]);
            Assert.AreEqual(1, sortedList[1]);
            Assert.AreEqual(9, sortedList[7]);
            Assert.AreEqual(10, sortedList[8]);
        } 
    }
}