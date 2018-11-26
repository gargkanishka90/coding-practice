using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.LinkedList;

namespace ScratchPadTests.Tests.LinkedListTests
{
    [TestFixture]
    public class CopyListRandomNodeTests
    {
        [Test]
        public void Test01()
        {
            var instance = new CopyListRandomNode();
            var node1 = new RandomListNode(1);
            var node2 = new RandomListNode(2);
            var node3 = new RandomListNode(3);
            var node4 = new RandomListNode(4);

            node1.next = node2;
            node1.random = node3;

            node2.next = node3;
            node2.random = node4;

            node3.next = node4;
            node3.random = node2;

            node4.random = node4;

            var test = instance.CopyRandomListOptimized(node1);
        }
    }
}
