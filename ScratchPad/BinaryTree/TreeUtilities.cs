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
                Console.Write("There are no elements in the tree.");
                return;
            }

            Console.WriteLine(root.data);

            PrintTree(root.left);
            PrintTree(root.right);
        }
    }
}
