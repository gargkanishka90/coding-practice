using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public static class BinaryTreeLeaves
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

        public class LeafNode
        {
            public int data { get; set; }    
            public LeafNode next { get; set; }

            public LeafNode(int data, LeafNode next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

        public static LeafNode FormLinkedListFromLeaves(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var dummyHead = new LeafNode(-1);
            LeavesHelper(root, dummyHead);
            return dummyHead.next;
        }

        private static void LeavesHelper(TreeNode root, LeafNode dummyHead)
        {
            if(root == null)
                return;

            //var runner = dummyHead;

            if (root.left == null && root.right == null)
            {
                var runner = dummyHead;
                while (runner.next != null)
                    runner = runner.next;
                runner.next = new LeafNode(root.data);
                return;
            }

            if (root.left != null)
            {
                LeavesHelper(root.left, dummyHead);
            }

            if (root.right != null)
            {
                LeavesHelper(root.right, dummyHead);
            }
        }
    }
}
