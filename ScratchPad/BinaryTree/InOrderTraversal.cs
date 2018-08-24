using System;
using System.Collections.Generic;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class InOrderTraversal
    {
        public static void InOrderTraverselRecursive(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraverselRecursive(root.left);
                Console.WriteLine(root.data);
                InOrderTraverselRecursive(root.right);
            }
        }

        public static void InOrderTraverselIterative(TreeNode root){
            var st = new Stack<TreeNode>();
            var current = root;
            while(current != null){
                st.Push(current);
                current = current.left;
            }

            while(st.Count > 0){
                var top = st.Pop();
                Console.WriteLine(top.data);
                if(top.right != null){
                    current = top.right;
                    while (current != null)
                    {
                        st.Push(current);
                        current = current.left;
                    }
                }
            }
        }

        /*
            Compute the K-th Node in an in-order traversal.
        */
        public static int ComputeKthNode(TreeNode root, int k)
        {
            if (root == null)
                return -1;

            while (root != null)
            {
                var leftTreeNodeCount = root.left != null ? CountNodes(root.left) : 0;
                if (leftTreeNodeCount + 1 == k)
                {
                    return root.data;
                }
                else if (leftTreeNodeCount + 1 < k)
                {
                    k -= (leftTreeNodeCount + 1);
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }

            return -1;
        }

        private static int CountNodes(TreeNode node)
        {
            if (node == null)
                return 0;

            return 1 + CountNodes(node.left) + CountNodes(node.right);
        }
    }
}
