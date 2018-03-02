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
                Console.Write(" null ");
                return;
            }

            Console.Write(root.data + " ");

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

        // This is the brute-force approach. Height() is called at every node starting from root.
        // Height() takes O(N) time and there are N nodes. So Time complexity is O(N^2)
        public static bool IsBalanced(TreeNode root){
            if (root == null)
                return true;

            var leftHeight = Height(root.left);
            var rightHeight = Height(root.right);

            return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }


        // This is an optimized version to check if a binary tree is balanced.
        // Worst-Case Occurs when a left-subtree is completely balanced and we are at root node
        // Hence, Time Complexity is O(Height of tree) - O(N)
        public static bool IsBalancedOptimized(TreeNode root){
            return DfsHeight(root) != -1;
        }

        public static int DfsHeight(TreeNode root){
            if (root == null)
                return 0;

            var left = DfsHeight(root.left);
            if (left == -1) return -1;

            var right = DfsHeight(root.right);
            if (right == -1) return -1;

            if (Math.Abs(left - right) > 1) return -1;

            return Math.Max(left, right) + 1;
        }
    }
}
