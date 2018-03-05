using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeLca
    {
        public static int FindLca(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root?.data ?? -1;

            var PathP = FindPath(root, p.data);
            var PathQ = FindPath(root, q.data);

            if (PathQ == null || PathP == null)
            {
                return -1;
            }

            var i = 0;
            for (i = 0; i < PathQ.Count && i < PathP.Count; i++)
            {
                if (PathQ[i].data != PathP[i].data)
                    break;
            }

            return PathP[i - 1].data;
        }

        public static int FindLcaWithParentLinks(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root?.data ?? -1;

            var runner1 = p;
            var runner2 = q;

            while (runner1 != null && runner2 != null)
            {
                if (runner1.parent == runner2.parent)
                {
                    return runner2.parent.data;
                }
                runner1 = runner1.parent;
                runner2 = runner2.parent;
            }

            return -1;
        }

        public static List<TreeNode> FindPath(TreeNode root, int k)
        {
            var result = new List<TreeNode>();
            return PathUtil(root, k, result) ? result : null;
        }

        private static bool PathUtil(TreeNode root, int k, List<TreeNode> result)
        {
            if (root == null)
            {
                return false;
            }

            result.Add(root);

            if (root.data == k)
            {
                return true;
            }

            if (root.left != null && PathUtil(root.left, k, result))
            {
                return true;
            }

            if (root.right != null && PathUtil(root.right, k, result))
            {
                return true;
            }

            result.RemoveAt(result.Count - 1);

            return false;
        }
    }
}
