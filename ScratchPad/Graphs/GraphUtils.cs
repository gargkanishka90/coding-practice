using System;
namespace ScratchPad.Graphs
{
    public class GraphUtils
    {
        public static Graph GenerateSampleUndirectedGraph(){
            Graph g = new Graph(5);

            g.AddEdge(0, 1);
            g.AddEdge(0, 4);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 4);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);

            return g;
        }

        public static Graph GenerateSampleDirectedGraph()
        {
            Graph g = new Graph(6, true);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(1, 4);
            g.AddEdge(2, 4);
            g.AddEdge(1, 3);
            g.AddEdge(3, 4);
            g.AddEdge(4, 5);

            return g;
        }

        public static void PrintSampleGraph(Graph g){
            for (var node = 0; node < g.VertexCount; node++)
            {
                Console.Write("Adjacency List for Vertex {0} ", node);
                foreach (var x in g.GetNeighbours(node))
                {
                    Console.Write(" -> " + x);
                }
                Console.WriteLine();
            }
        }
    }
}
