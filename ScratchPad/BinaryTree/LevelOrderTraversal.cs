using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class LevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrderTraveralRecursive(TreeNode root)
        {
            var res = new List<IList<int>>();
            Helper(root, 0, res);
            return res;
        }

        private static void Helper(TreeNode root, int level, IList<IList<int>> res)
        {
            if (root == null) return;

            if (res.Count <= level)
                res.Add(new List<int>());

            res[level].Add(root.data);

            if (root.left != null)
            {
                Helper(root.left, level + 1, res);
            }
            if (root.right != null)
            {
                Helper(root.right, level + 1, res);
            }
            return;
        }

        public static void LevelOrderTraversalIterative1(TreeNode root)
        {
            var height = TreeUtils.Height(root);
            for (var level = 0; level < height; level++)
            {
                PrintGivenLevel(root, level);
                Console.WriteLine();
            }
        }

        private static void PrintGivenLevel(TreeNode root, int level)
        {
            if (root == null) return;
            if (level == 0)
                Console.Write(root.data + " ");

            PrintGivenLevel(root.left, level - 1);
            PrintGivenLevel(root.right, level - 1);
        }

        public static void LevelOrderTraversalIterative2(TreeNode root)
        {
            if (root == null) return;

            var queue = new LinkedList<TreeNode>();

            queue.AddFirst(root);

            while (queue.Count != 0)
            {
                var temp = queue.Last();
                queue.RemoveLast();

                Console.WriteLine(temp.data);

                if (temp.left != null)
                {
                    queue.AddFirst(temp.left);
                }

                if (temp.right != null)
                {
                    queue.AddFirst(temp.right);
                }
            }
        }
    }
}
