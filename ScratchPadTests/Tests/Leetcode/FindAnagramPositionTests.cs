using System;
using NUnit.Framework;
using ScratchPad.Leetcode.Patterns.MinimumWindow;

namespace ScratchPadTests.Tests.Leetcode
{
    [TestFixture]
    public class FindAnagramPositionTests
    {
        [Test]
        public void Test01(){
            var instance = new FindAnagramPositions();
            var positions = instance.FindAnagrams("cbaebabacd", "abc");
        }
    }
}
