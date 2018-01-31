using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public static void LeverOrderTraversal(TreeNode root)
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