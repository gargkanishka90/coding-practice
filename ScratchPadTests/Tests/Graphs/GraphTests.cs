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
            GraphUtils.PrintSampleGraph(g);
            Console.WriteLine("--------------------------------");
            var dg = GraphUtils.GenerateSampleDirectedGraph();
            GraphUtils.PrintSampleGraph(dg);
            Console.WriteLine(Search.BFS(dg, 1, 5));
            Console.WriteLine(Search.BFS(dg, 3, 0));
        }

        [Test]
        public void BFSTest(){
            var g = GraphUtils.GenerateSampleUndirectedGraph();
            GraphUtils.PrintSampleGraph(g);
            var bfs = Search.BFS(g, 2);
            Assert.AreEqual(new List<int>{2,1,3,0,4}, bfs);
        }
    }
}
