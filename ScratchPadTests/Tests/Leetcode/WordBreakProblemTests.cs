using System;
using NUnit.Framework;
using ScratchPad.Leetcode;

namespace ScratchPadTests.Tests.Leetcode
{
    [TestFixture]
    public class WordBreakProblemTests
    {
        [Test]
        public void Test_Memoization(){
            var ins = new WordBreakProblem();
            var word = "ilikesamsung";
            var dict = new[] { "i", "like", "samsung", "sam" };
            //var resr = ins.WordBreak(word, dict);
            //Assert.IsTrue(resr);
            var resr = WordBreakProblem.WordBreakDP(word, dict);
            Assert.IsTrue(resr);
        }
    }
}
