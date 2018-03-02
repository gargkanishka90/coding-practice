using System;
using System.Collections.Generic;
using System.Linq;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                var temp = current.left;
                current.left = current.right;
                current.right = temp;
                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }

            return root;
        }
    }
}
