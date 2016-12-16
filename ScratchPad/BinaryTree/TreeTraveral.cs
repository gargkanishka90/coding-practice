using System;

namespace ScratchPadTests.BinaryTree
{
    public class TreeTraveral
    {
        public static void PreOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTraverse(root.left);
                PreOrderTraverse(root.right);
            }
        }

        public static void PostOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                PostOrderTraverse(root.left);
                PostOrderTraverse(root.right);
                Console.WriteLine(root.data);
            }
        }

        public static void InOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraverse(root.left);
                Console.WriteLine(root.data);
                InOrderTraverse(root.right);
            }
        }
    }
}