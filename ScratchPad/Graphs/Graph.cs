using System;
using System.Collections.Generic;

namespace ScratchPad.Graphs
{
    public class Graph
    {
        // Adjacency List Representation of a Graph Data Structure.

        public int VertexCount { get; set; }
        public List<int>[] AdjacencyList { get; set; }
        public bool directed { get; set; }

        public Graph(int vertexCount, bool directed = false)
        {
            this.VertexCount = vertexCount;
            AdjacencyList = new List<int>[vertexCount];
            this.directed = directed;
            for (var i = 0; i < AdjacencyList.Length; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int from, int to){
            AdjacencyList[from].Add(to);
            if(!directed){
                AdjacencyList[to].Add(from);
            }
        }

        public bool IsAnEdge(int from, int to){
            return AdjacencyList[from].Contains(to);
        }

        public List<int> GetNeighbours(int of){
            return AdjacencyList[of];
        }
    }
}
