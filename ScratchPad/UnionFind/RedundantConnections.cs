using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.UnionFind
{
    public class RedundantConnections
    {
        public int[] FindRedundantConnection(int[,] edges)
        {
            var numEdges = edges.GetLength(0);
            var nodes = new HashSet<int>();

            for (var e = 0; e < numEdges; e++)
            {
                var a = edges[e, 0];
                var b = edges[e, 1];
                nodes.Add(a);
                nodes.Add(b);
            }

            var uf = new UnionFind(nodes.Count + 1);

            foreach (var node in nodes)
            {
                uf.SetParent(node);
            }

            for (var e = 0; e < numEdges; e++)
            {
                var a = edges[e, 0];
                var b = edges[e, 1];
                if(!uf.Union(a, b))
                    return new[] { a, b };
            }

            return new[] { -1, -1};
        }

        public class UnionFind
        {
            public int[] Parent;
            public int[] Rank;
            public int Count = 0;
            public UnionFind(int n)
            {
                Parent = new int[n];
                Rank = new int[n];
                for (var i = 0; i < n; i++)
                {
                    Parent[i] = -1;
                }
            }

            public void SetParent(int id)
            {
                Parent[id] = id;
                Count++;
            }

            public int FindSet(int id)
            {
                var p = Parent[id];
                if (p == id)
                    return id;
                Parent[id] = FindSet(p);
                return Parent[id];
            }

            public bool Union(int id1, int id2)
            {
                var p1 = FindSet(id1);
                var p2 = FindSet(id2);

                if (p1 != p2)
                {
                    if (Rank[p1] > Rank[p2])
                    {
                        Parent[p2] = p1;
                    }
                    else if (Rank[p1] < Rank[p2])
                    {
                        Parent[p1] = p2;
                    }
                    else
                    {
                        Parent[p2] = p1;
                        Rank[p1] += 1;
                    }

                    return true;
                }

                return false;
            }
        }
    }
}
