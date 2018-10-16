using System;
using NUnit.Framework;
using ScratchPad.Leetcode.Hard;

namespace ScratchPadTests.Tests.Leetcode.Hard
{
    [TestFixture]
    public class MinWindowSubstringTests
    {
        [Test]
        public void Test01(){
            var instance = new MinWindowSubstring();
            var res = instance.MinWindow("abc", "ac");
        }
    }
}
