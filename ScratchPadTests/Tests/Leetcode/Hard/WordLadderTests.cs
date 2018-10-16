using System;
using System.Collections.Generic;
using NUnit.Framework;
using ScratchPad.Leetcode.Hard;

namespace ScratchPadTests.Tests.Leetcode.Hard
{
    [TestFixture]
    public class WordLadderTests
    {
        [Test]
        public void Test01(){
            var dict = new[] { "hot", "dot", "dog", "lot", "log", "cog" };
            var instance = new WordLadder();
            var dist = instance.LadderLength("hit", "cog", new List<string>(dict));
        }
    }
}
