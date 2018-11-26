using NUnit.Framework;
using ScratchPad.Hashing;

namespace ScratchPad.Tests.Hashing
{
    public class FrequencySortTest
    {
        [Test]
        public void DofrequencySort()
        {
            var res = FrequencySort.SortUsingHeap("raaeaedere");
            Assert.AreEqual("eeeeaaarrd", res);
        } 
    }
}