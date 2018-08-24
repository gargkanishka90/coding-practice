using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class PostOrderTraversal
    {
        public static IList<int> PostOrderTraversalRecursive(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PostOrderTraversalHelper(root, result);
            return result;
        }

        private static void PostOrderTraversalHelper(TreeNode root, List<int> result)
        {
            if (root == null) return;
            PostOrderTraversalHelper(root.left, result);
            PostOrderTraversalHelper(root.right, result);
            result.Add(root.data);
        }

        public static IList<int> PostOrderIterative(TreeNode root)
        {
            var result = new List<int>();
            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            var current = root;

            while (current != null)
            {
                stack1.Push(current);
                stack2.Push(current);
                current = current.right;
            }

            while (stack1.Count > 0)
            {
                var top = stack1.Pop();
                if (top.left != null)
                {
                    current = top.left;
                    while (current != null)
                    {
                        stack1.Push(current);
                        stack2.Push(current);
                        current = current.right;
                    }
                }
            }

            while (stack2.Count > 0)
            {
                result.Add(stack2.Pop().data);
            }
            return result;
        }
    }
}
