using System;
using System.Collections.Generic;
using System.Linq;
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
            // Time Complexity: O(n^2) in worst case. 
            // For a skewed tree, printGivenLevel() takes O(n) time 
            // where n is the number of nodes in the skewed tree. 
            // So time complexity of printLevelOrder() is O(n) + O(n-1) + O(n-2) + .. + O(1) which is O(n^2)

            var height = TreeUtils.Height(root);
            Console.WriteLine("Level By Level Order Traversal");
            Console.WriteLine("Height: " + height);
            for (var level = 1; level <= height; level++)
            {
                Console.Write($"Level {level}: ");
                PrintGivenLevel(root, level);
                Console.WriteLine();
            }
        }

        private static void PrintGivenLevel(TreeNode root, int level)
        {
            if (root == null) return;
            if (level == 1)
                Console.Write(root.data + " ");

            PrintGivenLevel(root.left, level - 1);
            PrintGivenLevel(root.right, level - 1);
        }

        public static void LevelOrderTraversalIterative3(TreeNode root)
        {
            // Time Complexity: O(n) where n is number of nodes in the binary tree
            if (root == null) return;
            var dict = new Dictionary<int, List<int>>();
            var queue = new Queue<TreeNode>();
            root.level = 1;
            queue.Enqueue(root);
            
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                if (dict.ContainsKey(temp.level))
                {
                    dict[temp.level].Add(temp.data);
                }
                else
                {
                    dict[temp.level] = new List<int>() {temp.data};
                }

                if (temp.left != null)
                {
                    var toAdd = temp.left;
                    toAdd.level = temp.level + 1;
                    queue.Enqueue(toAdd);
                }
                if (temp.right != null)
                {
                    var toAdd = temp.right;
                    toAdd.level = temp.level + 1;
                    queue.Enqueue(toAdd);
                }
            }

            Console.WriteLine("Level Order Traversal using BFS");
            foreach (var key in dict.Keys)
            {
                Console.Write("Level " + key + " - ");
                foreach (var val in dict[key])
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
