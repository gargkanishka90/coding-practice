using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Graphs
{
    public class DirectedGraphCycle
    {
        public static bool CycleDirectedGraphUsingDFS(Graph g)
        {
            var numVertex = g.V;

            var visited = new HashSet<int>();
            var visiting = new HashSet<int>();

            for (var i = 0; i < numVertex; i++)
            {
                if (CycleHelper(i, visited, visiting, g))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CycleHelper(int curr, ISet<int> visited, ISet<int> visiting, Graph g)
        {
            if (visiting.Contains(curr))
                return true;

            if (visited.Contains(curr))
                return false;

            visited.Add(curr);
            visiting.Add(curr);

            foreach (var node in g.Edges[curr])
            {
                if (CycleHelper(node, visited, visiting, g))
                {
                    return true;
                }
            }

            visiting.Remove(curr);
            return false;
        }

        public static bool CycleDetectionDirectedGraphUsingBFS(Graph g)
        {
            var numVertex = g.V;
            var indegree = g.GetInDegree();
            var visited = new HashSet<int>();

            var queue = new Queue<int>();

            for (var i = 0; i < numVertex; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                var head = queue.Dequeue();
                visited.Add(head);

                foreach (var nei in g.Edges[head])
                {
                    indegree[nei]--;
                    if (indegree[nei] == 0)
                    {
                        queue.Enqueue(nei);
                    }
                }
            }

            return visited.Count != numVertex;
        }

        public static bool DoesCycleExistsUsingBFS(Graph g)
        {
            var N = g.V;

            // Populate indegree
            var indegree = new Dictionary<int, int>();
            for (var v = 0; v < N; v++)
            {
                indegree[v] = 0;
            }

            foreach (var vertex in g.Edges)
            {
                foreach (var nei in vertex.Value)
                {
                    indegree[nei]++;
                }
            }

            var queue = new Queue<int>();
            var visited = new HashSet<int>();

            for (var v = 0; v < N; v++)
            {
                if(indegree[v] == 0)
                    queue.Enqueue(v);
            }

            while (queue.Count > 0)
            {
                var head = queue.Dequeue();
                visited.Add(head);

                foreach (var nei in g.Edges[head])
                {
                    indegree[nei]--;
                    if(indegree[nei] == 0)
                        queue.Enqueue(nei);
                }
            }

            return visited.Count != N;
        }

        public static bool DoesCycleExistsUsingDFS(Graph g)
        {
            var N = g.V;

            var visited = new HashSet<int>();
            var visiting = new HashSet<int>();

            for (var v = 0; v < N; v++)
            {
                if (CycleUtil(v, visited, visiting, g))
                    return true;
            }

            return false;
        }

        private static bool CycleUtil(int curr, HashSet<int> visited, HashSet<int> visiting, Graph graph)
        {
            if (visiting.Contains(curr))
                return true;

            if (visited.Contains(curr))
                return false;

            visited.Add(curr);
            visiting.Add(curr);

            foreach (var n in graph.Edges[curr])
            {
                if (CycleUtil(n, visited, visiting, graph))
                    return true;
            }

            visiting.Remove(curr);
            return false;
        }
    }

    public class Graph
    {
        public int V { get; set; }

        public IDictionary<int, ISet<int>> Edges;
        public Graph(int v)
        {
            V = v;
            Edges = new Dictionary<int, ISet<int>>();
            for (var i = 0; i < V; i++)
            {
                Edges[i] = new HashSet<int>();
            }
        }

        public void AddEdge(int a, int b)
        {
            Edges[a].Add(b);
        }

        public IDictionary<int, int> GetInDegree()
        {
            var indegree = new Dictionary<int,int>();

            for (var i = 0; i < V; i++)
            {
                indegree[i] = 0;
            }

            foreach (var source in Edges)
            {
                foreach (var nei in source.Value)
                {
                    indegree[nei]++;
                }
            }

            return indegree;
        }
    }
}
