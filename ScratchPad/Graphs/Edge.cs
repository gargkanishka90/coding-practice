using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Graphs
{
    public class Edge<T>
    {
        public bool Directed { get; set; }
        public int Cost { get; set; }

        public T Left { get; set; }
        public T Right { get; set; }

        public Vertex<T> LeftVertex { get; set; }

        public Vertex<T> RightVertex { get; set; }

        public Edge(int cost, Vertex<T> left, Vertex<T> right, bool directed = false)
        {
            Cost = cost;
            Directed = directed;
            Left = left.data;
            Right = right.data;
            LeftVertex = left;
            RightVertex = right;
        }

        public void PrintEdge()
        {
            Console.WriteLine($"{(Directed ? "D" : "Und")}irectedEdge from {Left} to {Right} with {Cost} cost.");
        }
    }
}
