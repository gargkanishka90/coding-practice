using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode.Matrix
{
    public class NumIslandsII
    {
        public IList<int> NumIslands2(int m, int n, int[,] positions)
        {
            var grid = new int[m, n];
            var result = new List<int>();

            if (positions == null || positions.GetLength(0) == 0)
                return result;

            var uf = new UnionFind(m*n);

            for (var i = 0; i < positions.GetLength(0); i++)
            {
                var x = positions[i, 0];
                var y = positions[i, 1];
                grid[x, y] = 1;
                var id1 = GetId(x, y, n);
                uf.SetParent(id1);

                if (x - 1 >= 0 && grid[x-1, y] == 1)
                {
                    var id2 = GetId(x - 1, y, n);
                    uf.Union(id1,id2);
                }

                if (y - 1 >= 0 && grid[x, y-1] == 1)
                {
                    var id2 = GetId(x, y - 1, n);
                    uf.Union(id1, id2);
                }

                if (x + 1 < m && grid[x+1, y] == 1)
                {
                    var id2 = GetId(x + 1, y, n);
                    uf.Union(id1, id2);
                }

                if (y + 1 < n && grid[x, y+1] == 1)
                {
                    var id2 = GetId(x, y + 1, n);
                    uf.Union(id1, id2);
                }

                result.Add(uf.Count);
            }

            return result;
        }

        private int GetId(int r, int c, int n)
        {
            return r * n + c;
        }
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
                Parent[i] = 1;
        }

        public void SetParent(int id)
        {
            Parent[id] = id;
        }

        public int FindSet(int id)
        {
            var p = Parent[id];
            if (p == id)
                return id;
            Parent[id] = FindSet(Parent[id]);
            return Parent[id];
        }

        public void Union(int id1, int id2)
        {
            var s1 = FindSet(id1);
            var s2 = FindSet(id2);

            if (s1 != s2)
            {
                if (Rank[s1] > Rank[s2])
                {
                    Parent[s2] = s1;
                }
                else if (Rank[s1] < Rank[s2])
                {
                    Parent[s1] = s2;
                }
                else
                {
                    Parent[s2] = s1;
                    Rank[s1] += 1;
                }

                Count++;
            }
        }
    }
}
