using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Arrays;
using ScratchPad.Heap;

namespace ScratchPadTests.Tests.Arrays
{
    [TestFixture]
    public class GeneralArrayTests
    {
        [Test]
        public void BinarySearchInsertIndexTest01()
        {
            var instance = new BinarySearch();

            var data = new [] {1, 2, 9, 14, 25, 36};

            var index = instance.FindInsertIndex(data, 4);
        }

        [Test]
        public void SearchInsertIndexTest02()
        {
            var instance = new BinarySearch();

            Assert.AreEqual(2, instance.SearchInsert_BinarySearch_Method1(new []{ 1, 3, 5, 6 }, 4));
            Assert.AreEqual(1, instance.SearchInsert_BinarySearch_Method1(new[] { 1, 3, 5, 6 }, 2));
            Assert.AreEqual(4, instance.SearchInsert_BinarySearch_Method1(new[] { 1, 3, 5, 6 }, 7));
            Assert.AreEqual(0, instance.SearchInsert_BinarySearch_Method1(new[] { 1, 3, 5, 6 }, 0));

            Assert.AreEqual(2, instance.SearchInsert_BinarySearch_Method2(new[] { 1, 3, 5, 6 }, 4));
            Assert.AreEqual(1, instance.SearchInsert_BinarySearch_Method2(new[] { 1, 3, 5, 6 }, 2));
            Assert.AreEqual(4, instance.SearchInsert_BinarySearch_Method2(new[] { 1, 3, 5, 6 }, 7));
            Assert.AreEqual(0, instance.SearchInsert_BinarySearch_Method2(new[] { 1, 3, 5, 6 }, 0));

            var instance1 = new SlidingWindowMaximum();
            var a = instance1.MaxSlidingWindow(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
        }
    }
}
