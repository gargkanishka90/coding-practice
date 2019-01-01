using System;
using System.Collections.Generic;

namespace ScratchPad.Graphs
{
    public class UndirectedGraphCycle
    {
        public static bool CycleUsingDFS(Graph g)
        {
            var numVertex = g.V;
            var visited = new HashSet<int>();

            for (var v = 0; v < numVertex; v++)
            {
                if(visited.Contains(v))
                    continue;

                if (CycleUtil(v, null, visited, g))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CycleUtil(int curr, int? parent, HashSet<int> visited, Graph graph)
        {
            throw new NotImplementedException();
        }
    }
}
