using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class KillProcesses
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var nodeToDirectChildren = new Dictionary<int, IList<int>>();

            for (var i = 0; i < pid.Count; i++)
            {
                var node = pid[i];
                var parentOfNode = ppid[i];
                if (parentOfNode != 0)
                {
                    if(!nodeToDirectChildren.ContainsKey(parentOfNode))
                        nodeToDirectChildren[parentOfNode] = new List<int>();

                    nodeToDirectChildren[parentOfNode].Add(node);
                }
            }

            var killed = new List<int>();

            PopulateKilled(killed, nodeToDirectChildren, kill);

            return killed;
        }

        private void PopulateKilled(List<int> killed, Dictionary<int, IList<int>> nodeToDirectChildren, int kill)
        {
            if (!nodeToDirectChildren.ContainsKey(kill))
            {
                killed.Add(kill);
                return;
            }

            killed.Add(kill);

            var children = nodeToDirectChildren[kill];

            foreach (var child in children)
            {
                PopulateKilled(killed, nodeToDirectChildren, child);
            }
        }
    }
}
