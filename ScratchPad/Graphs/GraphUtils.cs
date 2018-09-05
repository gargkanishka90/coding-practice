using System;
using System.Collections.Generic;

namespace ScratchPad.Graphs
{
    public class GraphUtils
    {
        public static Graph<int> GenerateSampleUndirectedGraph(){
            var g = new Graph<int>(5);
            g.AddAllVertices(new[] { 10, 20, 30, 40, 50 });

            g.AddNeighbors(10, new List<int>() { 20, 30 });
            g.AddNeighbors(20, new List<int>() { 10, 40 });
            g.AddNeighbors(30, new List<int>() { 10, 40, 50 });
            g.AddNeighbors(40, new List<int>() { 20, 30 });
            g.AddNeighbors(50, new List<int>() { 30 });

            return g;
        }

        //public static Graph GenerateSampleDirectedGraph()
        //{
        //    Graph g = new Graph(6, true);

        //    g.AddEdge(0, 1);
        //    g.AddEdge(0, 2);
        //    g.AddEdge(1, 2);
        //    g.AddEdge(1, 4);
        //    g.AddEdge(2, 4);
        //    g.AddEdge(1, 3);
        //    g.AddEdge(3, 4);
        //    g.AddEdge(4, 5);

        //    return g;
        //}

        public static void PrintSampleGraph(Graph<int> g){
            g.PrintAllVertices();
            Console.WriteLine();
            g.PrintAllEdges();
        }
    }
}
