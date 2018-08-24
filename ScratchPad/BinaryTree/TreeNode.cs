using System.Collections.Generic;

namespace ScratchPadTests.BinaryTree
{
    public class TreeNode
    {
        public TreeNode left, right, parent;
        public int data;
        public int level;

        public TreeNode()
        {
            left = null;
            right = null;
        }

        public TreeNode(int data, TreeNode left = null, TreeNode right = null, TreeNode parent = null)
        {
            this.data = data;
            this.left = left;
            this.right = right;
            this.parent = parent;
        }

        public static List<TreeNode> GetChildren(TreeNode root)
        {
            if (root == null) return null;

            if (root.left == null && root.right == null) return null;

            if(root.left == null && root.right != null) return new List<TreeNode>() {root.right};

            if (root.right == null && root.left != null) return new List<TreeNode>() { root.left };

            return new List<TreeNode>() { root.left, root.right};
        } 
    }
}