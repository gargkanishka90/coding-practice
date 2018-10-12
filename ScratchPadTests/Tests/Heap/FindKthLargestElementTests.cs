using System;
using NUnit.Framework;
using ScratchPad.Heap;

namespace ScratchPadTests.Tests.Heap
{
    [TestFixture]
    public class FindKthLargestElementTests
    {
        [Test]
        public void Test01()
        {
            var instance = new FindKthLargestElement();
            Assert.AreEqual(5, instance.Find(new[] { 3, 2, 1, 5, 6, 4 }, 2));
            Assert.AreEqual(4, instance.Find(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
        }
    }
}
