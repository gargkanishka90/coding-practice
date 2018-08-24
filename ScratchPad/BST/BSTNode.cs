using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BST
{
    public class BSTNode
    {
        public BSTNode left, right, parent;
        public int data;

        public BSTNode()
        {
            left = null;
            right = null;
        }

        public BSTNode(int data, BSTNode left = null, BSTNode right = null, BSTNode parent = null)
        {
            this.data = data;
            this.left = left;
            this.right = right;
            this.parent = parent;
        }

        public static List<BSTNode> GetChildren(BSTNode root)
        {
            if (root == null) return null;

            if (root.left == null && root.right == null) return null;

            if (root.left == null && root.right != null) return new List<BSTNode>() { root.right };

            if (root.right == null && root.left != null) return new List<BSTNode>() { root.left };

            return new List<BSTNode>() { root.left, root.right };
        }
    }
}
