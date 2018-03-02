using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BST
{
    public class FloorAndCeilBST
    {
        // Ceil Value Node: Node with smallest data larger than or equal to key value.
        public static BSTNode FindCeilNode(BSTNode root, int key)
        {
            if (root == null)
                return null;

            if (root.data == key)
                return root;

            if (key > root.data)
            {
                return FindCeilNode(root.right, key);
            }

            var ceil = FindCeilNode(root.left, key);
            if (ceil == null)
                return root;

            if (ceil.data >= key)
                return ceil;

            return root;
        }
    }
}
