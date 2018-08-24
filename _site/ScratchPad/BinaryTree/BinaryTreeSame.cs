using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeSame
    {
        public static bool IsSameTreeRecursive(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.data != q.data)
                return false;

            return IsSameTreeRecursive(p.left, q.left) && IsSameTreeRecursive(p.right, q.right);
        }

        public static bool IsSameTreeIterative(TreeNode p, TreeNode q)
        {
            // This problem can be solved iteratively by using two explicit stacks.

            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;
            var st1 = new Stack<TreeNode>();
            var st2 = new Stack<TreeNode>();
            st1.Push(p);
            st2.Push(q);

            while (st1.Count > 0 && st2.Count > 0)
            {
                var top1 = st1.Pop();
                var top2 = st2.Pop();

                if (top1.data != top2.data)
                    return false;

                if (top1.left != null)
                {
                    st1.Push(top1.left);
                }

                if (top2.left != null)
                {
                    st2.Push(top2.left);
                }

                if (st1.Count != st2.Count)
                    return false;

                if (top1.right != null)
                {
                    st1.Push(top1.right);
                }

                if (top2.right != null)
                {
                    st2.Push(top2.right);
                }

                if (st1.Count != st2.Count)
                    return false;
            }

            return st1.Count == st2.Count;
        }
    }
}
