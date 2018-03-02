using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeSymmetric
    {
        public static bool IsSymmetric(TreeNode root)
        {
            // Iterative Approach.
            if (root == null)
                return true;

            return IsSymmetricHelper(root);
        }

        private static bool IsSymmetricHelper(TreeNode root)
        {

            var q = new Queue<TreeNode>();

            q.Enqueue(root.left);
            q.Enqueue(root.right);

            while (q.Count > 0)
            {
                var l = q.Dequeue();
                var r = q.Dequeue();

                if (l == null && r == null)
                    continue;

                if (l == null && r != null)
                    return false;

                if (l != null && r == null)
                    return false;

                if (l.data != r.data)
                    return false;

                q.Enqueue(l.left);
                q.Enqueue(r.right);
                q.Enqueue(l.right);
                q.Enqueue(r.left);
            }

            return true;
        }
    }
}
