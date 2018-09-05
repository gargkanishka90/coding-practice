using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Graphs
{
    public class Graph<T>
    {
        public int VertexCount { get; set; }

        public bool Directed { get; set; }

        public Vertex<T>[] Vertices { get; set; }

        public Graph(int vertexCount, bool directed = false)
        {
            Directed = directed;
            VertexCount = vertexCount;
            Vertices = new Vertex<T>[vertexCount];
        }

        #region Graph Construction
        
        public void AddAllVertices(T[] items)
        {
            var id = 1;
            foreach (var item in items)
            {
                Vertices[id-1] = new Vertex<T>(id, item);
                id++;
            }
        }

        public void AddNeighbors(T item, IList<T> neighbors)
        {
            var fromVertex = Vertices.First(v => Equals(v.data, item));
            foreach (var neighbor in neighbors)
            {
                var toVertex = Vertices.First(v => Equals(v.data, neighbor));
                fromVertex.AddNeighborVertex(new Edge<T>(1, fromVertex, toVertex));
            }
        }

        #endregion

        #region Graph Printing
        public void PrintAllVertices()
        {
            foreach (var vertex in Vertices)
            {
                Console.WriteLine($"Vertex : {vertex.data}, Neighbors: {string.Join(" , ", vertex.Neighbors.ToList().Select(n => n.data))}");
            }
        }

        public void PrintAllEdges()
        {
            foreach (var vertex in Vertices)
            {
                vertex.Edges.ToList().ForEach(e => e.PrintEdge());
            }
        }

        #endregion

        #region Graph Traversal

        public List<T> BFS(Vertex<T> startNode = null)
        {
            if (startNode == null)
                startNode = Vertices[0];

            var queue = new Queue<Vertex<T>>();
            var traversal = new List<T>();
            queue.Enqueue(startNode);
            startNode.state = State.VISITING;

            while (queue.Count > 0)
            {
                var head = queue.Dequeue();
                head.state = State.VISITED;

                Console.WriteLine($"Visited Vertex with Id {head.id} and Data {head.data}");
                traversal.Add(head.data);

                foreach (var neighbor in head.Neighbors)
                {
                    if (neighbor.state == State.UNVISITED)
                    {
                        queue.Enqueue(neighbor);
                        neighbor.state = State.VISITING;
                    }
                }
            }

            return traversal;
        }

        #endregion
    }
}
