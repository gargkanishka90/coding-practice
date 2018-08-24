using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BST
{
    public static class BSTSuccessor
    {
        public static int FindInOrderSuccessor(BSTNode node)
        {
            var startNode = node;

            if (startNode.right != null)
            {
                var runner = startNode.right;
                while (runner.left != null)
                {
                    runner = runner.left;
                }
                return runner.data;
            }
            else
            {
                var runner = startNode;
                while (runner.parent != null && runner.parent.left != runner)
                {
                    runner = runner.parent;
                }
                return runner.parent?.data ?? -1;
            }
        }
    }
}
