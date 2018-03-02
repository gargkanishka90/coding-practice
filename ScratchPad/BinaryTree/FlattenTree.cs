using System;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public class FlattenTree
    {
        public static void FlattenBinaryTreeToLinkedList(TreeNode root)
        {
            if (root == null)
                return;

            var leftSubtree = root.left;
            var rightSubtree = root.right;

            // root's will now point to nothing
            root.left = null;

            // Recursively solve the left sub-problem
            FlattenBinaryTreeToLinkedList(leftSubtree);

            // Recursively solve the right sub-problem
            FlattenBinaryTreeToLinkedList(rightSubtree);

            root.right = leftSubtree;

            var runner = root;
            while (runner.right != null)
            {
                runner = runner.right;
            }

            runner.right = rightSubtree;
        }
    }
}
