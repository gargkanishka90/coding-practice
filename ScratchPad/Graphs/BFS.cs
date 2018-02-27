using System.Collections.Generic;

namespace ScratchPad.Graphs
{
    public static class BFS
    {
        public static List<int> Search(Graph g, int startNode){
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
    }
}
