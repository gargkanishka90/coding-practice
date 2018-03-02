using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeComputeLeaves
    {
        public static List<int> ComputeLeaves(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;
            ComputeLeavesHelper(root, result);
            return result;
        }

        private static void ComputeLeavesHelper(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                res.Add(root.data);
            }

            if (root.left != null)
            {
                ComputeLeavesHelper(root.left, res);
            }

            if (root.right != null)
            {
                ComputeLeavesHelper(root.right, res);
            }

            return;
        }
    }
}
