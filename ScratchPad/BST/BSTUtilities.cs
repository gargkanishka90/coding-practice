namespace ScratchPad.BST
{
    public class BSTUtilities
    {
        public static BinarySearchTree CreateRandomBST()
        {
            var tree = new BinarySearchTree();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            return tree;
        }

        public static BSTNode Search(BSTNode root, int key)
        {
            if (root == null || root.data == key)
                return root;

            if (root.data > key)
                return Search(root.left, key);

            return Search(root.right, key);
        }

        public static BSTNode Delete(BSTNode root, int key)
        {
            if (root == null) return root;

            if (key < root.data)
            {
                root.left = Delete(root.left, key);
            } else if (key > root.data)
            {
                root.right = Delete(root.right, key);
            }
            else
            {
                // Key to delete found at root.
                // Now 3 possibilities: 1. It has no children, 2. It has 1 child, and 3. It has two children.
                if (root.left == null)
                    return root.right;

                if (root.right == null)
                    return root.left;

                // node with two children: Get the inorder successor (smallest in the right subtree)
                root.data = GetMinimumValue(root.right); // Copy inorder successor into the root node
                
                // Delete the inorder successor recusively
                root.right = Delete(root.right, root.data);
            }
            return root;
        }

        public static int GetMinimumValue(BSTNode root)
        {
            var current = root;
            while (current.left != null)
            {
                current = current.left;
            }
            return current.data;
        }
    }
}
