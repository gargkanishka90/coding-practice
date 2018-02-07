using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
