using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreePathSum
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            return HasPathSumHelper(root, sum);
        }

        private static bool HasPathSumHelper(TreeNode root, int sum)
        {
            if (root.left == null && root.right == null && root.data == sum)
                return true;
            return HasPathSumHelper(root.left, sum - root.data) && HasPathSumHelper(root.right, sum - root.data);
        }
    }
}
