using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Greedy;

namespace ScratchPadTests.Tests.GreedyTests
{
    [TestFixture]
    public class PartitionLabelTests
    {
        [Test]
        public void Test01()
        {
            var instance = new PartitionLabels();
            Assert.AreEqual(new [] { 9, 7, 8 }, instance.Partition("ababcbacadefegdehijhklij"));
        }
    }
}
