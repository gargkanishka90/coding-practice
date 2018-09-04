using NUnit.Framework;
using ScratchPad.DynamicProgramming;

namespace ScratchPad.Tests
{
    public class LongestIncreasingSubsequenceTests
    {
        [Test]
        public void TestRecursiveLIS()
        {
            var lisCount = LongestIncreasingSubsequence.LISRecursive(new[] {10, 22, 9, 33, 21, 50, 41, 60});
            Assert.IsTrue(lisCount == 5);

            lisCount = LongestIncreasingSubsequence.LIS_DP(new[] { 10, 22, 9, 33, 21, 50, 41, 60 });
            Assert.IsTrue(lisCount == 5);
        } 
    }
}