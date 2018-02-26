using System;
using NUnit.Framework;
using ScratchPad.Graphs;

namespace ScratchPad.Tests.Graphs
{
    [TestFixture]
    public class GraphTests
    {
        [Test]
        public void CreateGraphTest(){
            var node1 = new GraphNode(1);
            var node2 = new GraphNode(2);
            var node3 = new GraphNode(3);
            var node4 = new GraphNode(4);
            var node5 = new GraphNode(5);
            var node6 = new GraphNode(6);
            node1.Neighbours = new GraphNode[] { node2, node3, node4 };
            node4.Neighbours = new GraphNode[] { node5, node6 };
            Assert.AreEqual(3, node1.Neighbours.Length);
            Assert.AreEqual(2, node4.Neighbours.Length);
        }
    }
}
