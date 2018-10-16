using System;
using NUnit.Framework;
using ScratchPad.Leetcode.Patterns.MinimumWindow;

namespace ScratchPadTests.Tests.Leetcode
{
    [TestFixture]
    public class PermutationInAStringTests
    {
        [Test]
        public void Test01(){
            var instance = new PermutationInAString567();
            var res = instance.CheckInclusion("ab", "eidbaooo");
        }
    }
}
