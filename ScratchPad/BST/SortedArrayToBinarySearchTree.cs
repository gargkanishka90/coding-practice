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
            return SortedArrayToBstHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode SortedArrayToBstHelper(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var mid = start + (end - start) / 2;

            var rootNode = new TreeNode(nums[mid]);

            rootNode.left = SortedArrayToBstHelper(nums, start, mid - 1);
            rootNode.right = SortedArrayToBstHelper(nums, mid + 1, end);

            return rootNode;
        }
    }
}
