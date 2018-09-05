using System;
using System.Collections.Generic;
using NUnit.Framework;
using ScratchPad.Graphs;

namespace ScratchPad.Tests.Graphs
{
    [TestFixture]
    public class GraphTests
    {
        [Test]
        public void CreateGraphTest(){
            var g = GraphUtils.GenerateSampleUndirectedGraph();

            g.PrintAllVertices();
            g.PrintAllEdges();
        }

        [Test]
        public void BFSTest(){
            var g = GraphUtils.GenerateSampleUndirectedGraph();

            g.PrintAllVertices();
            g.PrintAllEdges();
            var bfs = g.BFS();
            Assert.AreEqual(new List<int>{10,20,30,40,50}, bfs);
        }
    }
}
