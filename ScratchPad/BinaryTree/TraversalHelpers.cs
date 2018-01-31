using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public class TraversalHelpers
    {
        public static void InOrderTraversal(TreeNode root)
        {
            if(root == null) return;

            InOrderTraversal(root.left);
            Console.WriteLine(root.data);
            InOrderTraversal(root.right);
        }

        public static IList<int> PreOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PreOrderTraversalHelper(root, result);
            return result;
        }

        private static void PreOrderTraversalHelper(TreeNode root, List<int> result)
        {
            if(root == null) return;
            result.Add(root.data);
            PreOrderTraversalHelper(root.left, result);
            PreOrderTraversalHelper(root.right, result);
        }

        public static IList<int> PostOrderTraversal(TreeNode root)
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

        public static IList<IList<int>> LevelOrderTraveral(TreeNode root)
        {
            var res = new List<IList<int>>();
            LevelOrderUtil(root, 0, res);
            return res;
        }

        private static void LevelOrderUtil(TreeNode root, int level, IList<IList<int>> res)
        {
            if (root == null) return;

            if (res.Count <= level)
                res.Add(new List<int>());

            res[level].Add(root.data);

            if (root.left != null)
            {
                LevelOrderUtil(root.left, level + 1, res);
            }
            if (root.right != null)
            {
                LevelOrderUtil(root.right, level + 1, res);
            }
            return;
        }

        public static void LevelOrderTraveral2(TreeNode root)
        {
            var height = TreeHelpers.Height(root);
            for (var level = 0; level < height; level++)
            {
                PrintGivenLevel(root, level);
                Console.WriteLine();
            }
        }

        private static void PrintGivenLevel(TreeNode root, int level)
        {
            if (root == null) return;
            if(level == 0)
                Console.Write(root.data + " ");

            PrintGivenLevel(root.left, level-1);
            PrintGivenLevel(root.right, level - 1);
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
