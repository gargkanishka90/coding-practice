namespace ScratchPadTests.BinaryTree
{
    public class TreeNode
    {
        public TreeNode left, right;
        public int data;

        public TreeNode()
        {
            left = null;
            right = null;
        }

        public TreeNode(int data, TreeNode left = null, TreeNode right = null)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }
}