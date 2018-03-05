using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BST
{
    public class LowestCommonAncestorBST
    {
        public static int FindLca(BSTNode root, BSTNode first, BSTNode second)
        {
            if (root == null || first == root || second == root)
                return root?.data ?? -1;

            var firstPath = BSTUtilities.FindPath(root, first.data);
            var secondPath = BSTUtilities.FindPath(root, second.data);

            var i = 0;
            for (i = 0; i < firstPath.Count && i < secondPath.Count; i++)
            {
                if (firstPath[i] != secondPath[i])
                    break;
            }

            return firstPath[i-1];
        }

        public static int FindLcaUsingRecursion(BSTNode root, BSTNode first, BSTNode second)
        {
            if (root == null)
                return -1;

            if (first.data < root.data && second.data < root.data)
            {
                return FindLcaUsingRecursion(root.left, first, second);
            }

            if (first.data > root.data && second.data > root.data)
            {
                return FindLcaUsingRecursion(root.right, first, second);
            }

            return root.data;
        }

        public static int FindLcaUsingIteration(BSTNode root, BSTNode first, BSTNode second)
        {
            if (root == null)
                return -1;

            while (root != null)
            {
                if (first.data < root.data && second.data < root.data)
                {
                    root = root.left;
                }

                else if (first.data > root.data && second.data > root.data)
                {
                    root = root.right;
                }

                else
                {
                    break;
                }
            }

            return root?.data ?? -1;
        }
    }
}
