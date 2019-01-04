using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.UnionFind
{
    public class UnionFind
    {
        private int[] parent;
        public UnionFind(int n)
        {
            parent = new int[n];
        }

        public void Union(int x, int y, int[] parent)
        {
            var xS = Find(x, parent);
            var yS = Find(y, parent);
            if (xS != yS)
            {
                parent[y] = xS;
            }
        }

        public int Find(int x, int[] parent)
        {
            if (parent[x] == -1)
                return x;
            return Find(parent[x], parent);
        }
    }
}
