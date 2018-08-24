using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BST
{
    public class PreOrderToBST
    {
        public static BinarySearchTree Construct(int[] preOrder)
        {
            if (preOrder.Length == 0) return null;
            var tree = new BinarySearchTree();
            tree._root = ConstructRec(preOrder, 0, preOrder.Length - 1);
            return tree;
        }

        private static BSTNode ConstructRec(int[] preOrder, int start, int end)
        {
            if (end < start || start >= preOrder.Length) return null;

            var root = preOrder[start];
            var tree = new BinarySearchTree();
            tree.Insert(root);

            if (start == end)
            {
                return tree._root;
            }

            var i = FindIndexOfSuccessor(preOrder, root, start, end);
            tree._root.left = ConstructRec(preOrder, start + 1, i - 1);
            tree._root.right = ConstructRec(preOrder, i, end);

            return tree._root;
        }

        private static int FindIndexOfSuccessor(int[] preOrder, int root, int start, int end)
        {
            var successorIndex = start;
            for(var i = start; i <= end; i++)
            {
                if (preOrder[i] > root)
                {
                    successorIndex = i;
                    break;
                }
            }
            return successorIndex;
        }
    }
}
