using NUnit.Framework;
using ScratchPad.Hashing;

namespace ScratchPad.Tests.Hashing
{
    public class KMostFrequentlyTest
    {
        [Test]
        public void KMost()
        {
            var res = KMostFrequently.Find(new[] {1, 1, 1, 2, 2, 3}, 2);
        } 
    }
}