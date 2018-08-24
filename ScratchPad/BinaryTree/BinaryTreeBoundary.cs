using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeBoundary
    {
        // We could divide the tree into two subtrees. One is the left subtree, and the other is the right subtree. 
        // For the left subtree, we print the leftmost edges from top to bottom. 
        // Then we print its leaves from left to right. 
        // For the right subtree, we print its leaves from left to right, then its rightmost edges from bottom to top.
        public static List<int> PrintBoundary(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PrintBoundaryHelper(root, result);
            return result;
        }

        private static void PrintBoundaryHelper(TreeNode root, List<int> result)
        {
            if (root == null)
            {
                return; 
            }

            var left = root.left;
            var right = root.right;

            var runner1 = root;

            while (runner1 != null)
            {
                result.Add(runner1.data);
                runner1 = runner1.left;
            }

            var leftLeaves = BinaryTreeLeaves.ComputeLeaves(left).Skip(1);
            result.AddRange(leftLeaves);

            var runner2 = root;
            var rightStack = new Stack<int>();
            while (runner2.right != null)
            {
                rightStack.Push(runner2.data);
                runner2 = runner2.right;
            }

            var rightLeaves = BinaryTreeLeaves.ComputeLeaves(right);
            result.AddRange(rightLeaves);

            while (rightStack.Count > 1)
            {
                result.Add(rightStack.Pop());
            }
        }
    }
}
