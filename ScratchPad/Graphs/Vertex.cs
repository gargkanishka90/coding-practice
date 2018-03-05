using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Graphs
{
    public class Vertex<T>
    {
        public T data { get; set; }
        public int id { get; set; }
        public IList<Edge<T>> Edges { get; set; }
        public IList<Vertex<T>> Neighbors { get; set; }

        public int Degree => Edges.Count;

        public Vertex(int id, T data)
        {
            this.id = id;
            this.data = data;
            Edges = new List<Edge<T>>();
            Neighbors = new List<Vertex<T>>();
        }

        public void AddNeighborVertex(Edge<T> e, Vertex<T> v)
        {
            Edges.Add(e);
            Neighbors.Add(v);
        }
    }
}
