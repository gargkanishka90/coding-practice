using System;
using System.Collections.Generic;
using PracticePad.Leetcode;

namespace ScratchPadTests.BinaryTree
{
    public class TreeHelpers
    {
        public static TreeNode CreateRandomTree()
        {
            var Node1 = new TreeNode(3);
            var Node2 = new TreeNode(9);
            var Node3 = new TreeNode(20);
            var Node4 = new TreeNode(15);
            var Node5 = new TreeNode(7);
            var Node6 = new TreeNode(810);
            Node1.left = Node2;
            Node1.right = Node3;
            Node3.left = Node4;
            Node3.right = Node5;
            //Node3.left = Node6;
            return Node1;
        }

        public static int Height(TreeNode root)
        {
            if (root == null) return 0;

            var left = Height(root.left);
            var right = Height(root.right);
            return 1 + Math.Max(left, right);
        }
    }
}