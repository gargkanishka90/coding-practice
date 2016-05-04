using System;

namespace ScratchPadTests.BinaryTree
{
    public class PreOrder
    {
        public static void Traverse(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                Traverse(root.left);
                Traverse(root.right);
            }
        } 
    }
}