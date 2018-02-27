using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class TreeUtils
    {
        public static TreeNode CreateRandomTree()
        {
            var node1 = new TreeNode(6);
            var node2 = new TreeNode(8);
            var node3 = new TreeNode(10);
            var node4 = new TreeNode(16);
            var node5 = new TreeNode(58);
            var node6 = new TreeNode(810);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            return node1;
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
