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
    }
}
