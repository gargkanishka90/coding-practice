using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Graphs
{
    public static class Search
    {
        public static List<int> BFS(Graph g, int startNode)
        {
            var result = new List<int>();
            var visited = new bool[g.VertexCount];

            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                visited[temp] = true;
                result.Add(temp);
                foreach (var node in g.AdjacencyList[temp])
                {
                    if (!visited[node])
                    {
                        visited[node] = true;
                        queue.Enqueue(node);
                    }
                }
            }
            return result;
        }

        public enum State { VISITED, VISITING, UNVISITED };

        public class GNode
        {
            public int data { get; set; }
            public State state { get; set; }
        }

        public static bool BFS(Graph g, int start, int end)
        {
            if (start == end) return true;

            var nodes = new List<GNode>();

            for (var node = 0; node < g.VertexCount; node++)
            {
                nodes.Add(new GNode { data = node, state = State.UNVISITED });
            }

            var queue = new Queue<GNode>();
            queue.Enqueue(new GNode { data = start, state = State.VISITING });

            while (queue.Any())
            {
                var temp = queue.Dequeue();
                if (temp != null)
                {
                    foreach (var neighbor in g.GetNeighbours(temp.data))
                    {
                        if (nodes[neighbor].state == State.UNVISITED)
                        {
                            if (nodes[neighbor].data == end)
                            {
                                return true;
                            }
                            else
                            {
                                queue.Enqueue(new GNode() { data = neighbor, state = State.VISITING });

                            }
                        }
                    }
                }
                temp.state = State.VISITED;
            }
            return false;
        }
    }
}
