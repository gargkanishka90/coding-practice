using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BST
{
    public static class SortedArrayToBinarySearchTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode SortedArrayToBSTHelper(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var mid = (end + start) / 2;

            var result = new TreeNode(nums[mid]);

            result.left = SortedArrayToBSTHelper(nums, start, mid - 1);
            result.right = SortedArrayToBSTHelper(nums, mid + 1, end);

            return result;
        }
    }
}
