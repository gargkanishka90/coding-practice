using System.Collections.Generic;
using NUnit.Framework;
using ScratchPad.Leetcode;

namespace ScratchPadTests.Tests.Leetcode
{
    [TestFixture]
    public class TopKFrequentWordFinderTests
    {
        [Test]
        public void Test01()
        {
            var instance = new TopKFrequentWordFinder();
            var input = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
            var res = instance.Find(input, 2);
            Assert.AreEqual(new List<string>() { "i", "love" }, res);
        }

        [Test]
        public void Test02()
        {
            var instance = new TopKFrequentWordFinder();
            var input = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            var res = instance.Find(input, 4);
            Assert.AreEqual(new List<string>() { "the", "is", "sunny", "day" }, res);
        }
    }
}
