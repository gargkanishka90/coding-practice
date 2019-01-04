using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ScratchPad.Graphs
{
    public class Components
    {
        public int CountComponents(int n, int[,] edges)
        {
            var nodes = new HashSet<int>();
            var graph = new Dictionary<int, ISet<int>>();
            var numEdges = edges.GetLength(0);

            for (var i = 0; i < n; i++)
            {
                nodes.Add(i);
                graph[i] = new HashSet<int>();
            }

            for (var e = 0; e < numEdges; e++)
            {
                var n1 = edges[e, 0];
                var n2 = edges[e, 1];
                graph[n1].Add(n2);
                graph[n2].Add(n1);
            }

            //var numComponents = DFS(nodes, graph);
            //var numComponents = BFS(nodes, graph);
            var numComponents = FindUsingUnionFind(nodes, edges);

            return numComponents;
        }

        private int FindUsingUnionFind(HashSet<int> nodes, int[,] edges)
        {
            var parent = new int[nodes.Count];
            var numEdges = edges.GetLength(0);

            foreach (var node in nodes)
            {
                parent[node] = node;
            }

            var k = nodes.Count;

            for (var e = 0; e < numEdges; e++)
            {
                var n1 = edges[e, 0];
                var n2 = edges[e, 1];
                var s1 = FindSet(parent, n1);
                var s2 = FindSet(parent, n2);
                if (s1 != s2)
                {
                    Union(parent, s1, s2);
                    k--;
                }
            }

            return k;
        }

        private void Union(int[] parent, int n1, int n2)
        {
            parent[n1] = n2;
        }

        private int FindSet(int[] parent, int n1)
        {
            var p1 = parent[n1];
            if (p1 == n1)
                return n1;
            parent[n1] = FindSet(parent, p1);
            return parent[n1];
        }

        private int BFS(HashSet<int> nodes, Dictionary<int, ISet<int>> graph)
        {
            var count = 0;
            var q = new Queue<int>();
            var visited = new HashSet<int>();

            while (nodes.Count > 0)
            {
                q.Enqueue(nodes.First());
                count++;

                while (q.Count > 0)
                {
                    var head = q.Dequeue();
                    visited.Add(head);
                    nodes.Remove(head);

                    foreach (var nei in graph[head])
                    {
                        if (!visited.Contains(nei))
                            q.Enqueue(nei);
                    }
                }
            }
            
            return count;
        }

        private int DFS(HashSet<int> nodes, Dictionary<int, ISet<int>> graph)
        {
            var count = 0;
            var visited = new HashSet<int>();

            foreach (var node in nodes)
            {
                if (!visited.Contains(node))
                {
                    DFSUtil(node, visited, graph);
                    count++;
                }
            }

            return count;
        }

        private void DFSUtil(int node, HashSet<int> visited, Dictionary<int, ISet<int>> graph)
        {
            if (visited.Contains(node))
                return;

            visited.Add(node);

            foreach (var nei in graph[node])
            {
                DFSUtil(nei, visited, graph);
            }
        }
    }
}
