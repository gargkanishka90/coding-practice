using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class PreOrderTraversal
    {
        public static IList<int> PreOrderTraversalRecursive(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PreOrderTraversalHelper(root, result);
            return result;
        }

        private static void PreOrderTraversalHelper(TreeNode root, List<int> result)
        {
            if (root == null) return;
            result.Add(root.data);
            PreOrderTraversalHelper(root.left, result);
            PreOrderTraversalHelper(root.right, result);
        }

        public static IList<int> PreOrderIterative(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            var current = root;
            var stack = new Stack<TreeNode>();

            while (current != null)
            {
                result.Add(current.data);
                stack.Push(current);
                current = current.left;
            }

            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                if (temp.right != null)
                {
                    current = temp.right;
                    while (current != null)
                    {
                        result.Add(current.data);
                        stack.Push(current);
                        current = current.left;
                    }
                }
            }

            return result;
        }
    }
}
