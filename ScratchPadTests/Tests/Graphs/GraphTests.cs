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

        [Test]
        public void MazeTests()
        {
            var maze = new Maze();
            var grid = new int[,]
            {
                {0, 0, 0, 0, 0},
                {1, 1, 0, 0, 1},
                {0, 0, 0, 0, 0},
                {0, 1, 0, 0, 1},
                {0, 1, 0, 0, 0}
            };
            //maze.FindShortestWay(grid, new[] {4, 3}, new[] {0, 1});

            grid = new int[,]
            {
                {0, 0, 0, 0, 0},
                {1, 1, 0, 0, 1},
                {0, 0, 0, 0, 0},
                {0, 1, 0, 0, 1},
                {0, 1, 0, 0, 0}
            };

            var path = maze.FindStartToEndPath(grid, new[] {4, 0}, new[] {0, 4});

            foreach (var point in path)
            {
                Console.WriteLine($"{point.X}, {point.Y}");
            }
        }

        [Test]
        public void CycleTests_Directed_StronglyConnected_DFS()
        {
            var graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            var result = DirectedGraphCycle.DoesCycleExistsUsingDFS(graph);
            Assert.IsTrue(result);

            if (result)
                Console.WriteLine("Graph contains cycle"); 
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");

            var g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(3, 5);

            result = DirectedGraphCycle.DoesCycleExistsUsingDFS(graph);
            Assert.IsTrue(result);

            if (result)
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");
        }

        [Test]
        public void CycleTests_Directed_WeaklyConnected_DFS()
        {
            // No cycle
            var g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);

            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(3, 5);

            if (DirectedGraphCycle.DoesCycleExistsUsingDFS(g))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");

            // Yes cycle
            g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);

            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(5, 3);

            if (DirectedGraphCycle.DoesCycleExistsUsingDFS(g))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");
        }

        [Test]
        public void CycleTests_Directed_StronglyConnected_BFS()
        {
            var graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            if (DirectedGraphCycle.DoesCycleExistsUsingBFS(graph))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");

            var g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(3, 5);

            if (DirectedGraphCycle.DoesCycleExistsUsingBFS(g))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");
        }

        [Test]
        public void CycleTests_Directed_WeaklyConnected_BFS()
        {
            // No cycle
            var g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);

            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(3, 5);

            if (DirectedGraphCycle.DoesCycleExistsUsingBFS(g))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");

            // Yes cycle
            g = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);

            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(5, 3);

            if (DirectedGraphCycle.DoesCycleExistsUsingBFS(g))
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't " + "contain cycle");
        }
    }
}
