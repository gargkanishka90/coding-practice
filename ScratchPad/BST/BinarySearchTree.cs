using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.BST
{
    public class BinarySearchTree
    {
        public BSTNode _root;

        public BinarySearchTree()
        {
            _root = null;
        }

        public void Insert(int key)
        {
            _root = InsertRecursive(_root, key);
        }

        private BSTNode InsertRecursive(BSTNode root, int key)
        {
            if (root == null)
            {
                root = new BSTNode(key);
                return root;
            }

            if (key < root.data)
            {
                root.left = InsertRecursive(root.left, key);
            }
            else if (key > root.data)
            {
                root.right = InsertRecursive(root.right, key);
            }

            return root;
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(_root);
        }

        private void InOrderRecursive(BSTNode root)
        {
            if (root != null)
            {
                InOrderRecursive(root.left);
                Console.Write(root.data + " , ");
                InOrderRecursive(root.right);
            }
        }
    }
}
