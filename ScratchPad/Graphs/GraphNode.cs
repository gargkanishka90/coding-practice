using System;
namespace ScratchPad.Graphs
{
    public class GraphNode
    {
        public int data { get; set; }
        public GraphNode[] Neighbours { get; set; }

        public GraphNode(int data)
        {
            this.data = data;
        }
    }
}
