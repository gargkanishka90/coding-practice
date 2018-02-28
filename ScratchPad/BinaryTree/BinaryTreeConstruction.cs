using System;
using System.Collections.Generic;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeConstruction
    {
        public static TreeNode BuildTreeFromPreOrderInOrder(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 && inorder.Length == 0)
                return null;

            if (preorder.Length != inorder.Length || preorder.Length == 0 || inorder.Length == 0)
                throw new Exception();

            var inOrderIndexMap = new Dictionary<int, int>();

            for (var i = 0; i < inorder.Length; i++){
                inOrderIndexMap[inorder[i]] = i;    
            }

            return Helper(preorder, 0, preorder.Length, inorder, 0, inorder.Length, inOrderIndexMap);
        }

        private static TreeNode Helper(int[] preorder, int pStart, int pEnd, 
                                       int[] inorder, int iStart, int iEnd,
                                       IDictionary<int, int> inOrderIndexMap){
            if (pStart >= pEnd || iStart >= iEnd)
                return null;

            var rootIndex = inOrderIndexMap[preorder[pStart]];
            var leftTreeSize = rootIndex - iStart;

            var root = new TreeNode(preorder[pStart]);
            root.left = Helper(preorder, pStart + 1, pStart + 1 + leftTreeSize, inorder, iStart, rootIndex, inOrderIndexMap);
            root.right = Helper(preorder, pStart + 1 + leftTreeSize, pEnd, inorder, rootIndex + 1, iEnd, inOrderIndexMap);
            return root;
        }
    }
}
