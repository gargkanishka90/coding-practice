using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BST
{
    public static class BSTSerialization
    {
        public static TreeNode DeserializeBST(int[] preorder)
        {
            var root = new TreeNode();
            return DeserializeBSTHelper(root, preorder, 0, int.MaxValue, int.MinValue);
        }

        private static TreeNode DeserializeBSTHelper(TreeNode node, int[] preorder, int start, int max, int min)
        {
            if (preorder[start] >= min && preorder[start] <= max)
            {
                node = new TreeNode(preorder[start]);
                DeserializeBSTHelper(node.left, preorder, start + 1, node.data, min);
                DeserializeBSTHelper(node.right, preorder, start + 1, max, node.data);
                return node;
            }
            return null;
        }
    }
}
