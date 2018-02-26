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
			Graph g = new Graph(4);

			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 2);
			g.AddEdge(2, 0);
			g.AddEdge(2, 3);
			g.AddEdge(3, 3);

            Assert.AreEqual(new List<int>{1,2}, g.AdjacencyList[0]);
        }

        [Test]
        public void BFSTest(){
			Graph g = new Graph(4);

			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 2);
			g.AddEdge(2, 0);
			g.AddEdge(2, 3);
			g.AddEdge(3, 3);

            var bfs = BFS.Search(g, 2);
            Assert.AreEqual(new List<int>(){2,0,3,1}, bfs);
        }
    }
}
