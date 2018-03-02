using System;
using System.Collections.Generic;

namespace ScratchPad.Graphs
{
    public class Graph
    {
        // Adjacency List Representation of a Graph Data Structure.

        public int VertexCount { get; set; }
        public List<int>[] AdjacencyList { get; set; }

        public Graph(int vertexCount)
        {
            this.VertexCount = vertexCount;
            AdjacencyList = new List<int>[vertexCount];
            for (var i = 0; i < AdjacencyList.Length; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int from, int to){
            AdjacencyList[from].Add(to);
        }

        public bool IsAnEdge(int from, int to){
            return AdjacencyList[from].Contains(to);
        }

        public List<int> GetNeighbours(int of){
            return AdjacencyList[of];
        }
    }
}
