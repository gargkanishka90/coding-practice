using System;
using NUnit.Framework;
using ScratchPad.DynamicProgramming;

namespace ScratchPadTests.Tests.DynamicProgramming
{
    [TestFixture]
    public class KnapSackProblemTests
    {
        [Test]
        public void Test01(){
            var instance = new KnapSackProblem();
            var items = new []{ 60, 50, 70, 30 };
            var weights = new[] { 5, 3, 4, 2 };
            var opt = instance.FindOptimalWeight(items, weights, 5);
            Assert.AreEqual(80, opt);
        }
    }
}
