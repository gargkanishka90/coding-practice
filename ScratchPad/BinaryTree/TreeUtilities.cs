using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.BST;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class TreeUtils
    {
        public static TreeNode CreateRandomTree()
        {
            var r = new Random();
            var size = r.Next(0, 32);
            var arr = new int[size];
            for (var pos = 0; pos < size; pos++)
            {
                arr[pos] = r.Next(1, 100);
            }

            var root = SortedArrayToBinarySearchTree.SortedArrayToBST(arr);
            return root;
        }

        public static TreeNode CreateRandomPerfectTree()
        {
            var r = new Random();
            var size = (int)Math.Pow(2, r.Next(0, 7)) - 1;
            Console.WriteLine("Size: " + size);
            var arr = new int[size];
            for (var pos = 0; pos < size; pos++)
            {
                arr[pos] = r.Next(1, 100);
            }

            var root = SortedArrayToBinarySearchTree.SortedArrayToBST(arr);
            return root;
        }

        public static int Height(TreeNode root)
        {
            if (root == null) return 0;

            var left = Height(root.left);
            var right = Height(root.right);
            return 1 + Math.Max(left, right);
        }

        public static void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                Console.Write("Null");
                Console.WriteLine();
                //Console.Write("There are no elements in the tree.");
                return;
            }

            Console.WriteLine(root.data);

            PrintTree(root.left);
            PrintTree(root.right);
        }

        public static void PrintTreeLevelByLevel(TreeNode root)
        {
            var height = TreeUtils.Height(root);
            
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
    }
}
