namespace ScratchPadTests.BinaryTree
{
    public class TreeHelpers
    {
        public static TreeNode CreateRandomTree()
        {
            var Node1 = new TreeNode(6);
            var Node2 = new TreeNode(8);
            var Node3 = new TreeNode(10);
            var Node4 = new TreeNode(16);
            var Node5 = new TreeNode(58);
            var Node6 = new TreeNode(810);
            Node1.left = Node2;
            Node1.right = Node3;
            Node2.left = Node4;
            Node2.right = Node5;
            Node3.left = Node6;
            return Node1;
        } 
    }
}