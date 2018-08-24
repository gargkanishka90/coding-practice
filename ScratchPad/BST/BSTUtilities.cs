using System;
using System.Collections.Generic;

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

        public static BSTNode CreateSampleBSTWithLinkToParents()
        {
            var node20 = new BSTNode(20);
            var node8 = new BSTNode(8);
            var node22 = new BSTNode(22);
            var node4 = new BSTNode(4);
            var node12 = new BSTNode(12);
            var node10 = new BSTNode(10);
            var node14 = new BSTNode(14);
            node20.left = node8;
            node20.right = node22;

            node8.left = node4;
            node8.right = node12;
            node8.parent = node20;

            node22.parent = node20;
            node4.parent = node8;

            node12.parent = node8;
            node12.left = node10;
            node12.right = node14;

            node10.parent = node12;
            node14.parent = node12;

            return node20;
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

        public static List<int> FindPath(BSTNode root, int k)
        {
            var result = new List<int>();
            if (root == null) return result;
            FindPathHelper(root, k, result);
            return result;
        }

        private static void FindPathHelper(BSTNode root, int k, List<int> result)
        {
            if (root == null)
            {
                return;
            }

            if (root.data == k)
            {
                result.Add(root.data);
                return;
            }
            else if (root.data < k)
            {
                result.Add(root.data);
                FindPathHelper(root.right, k, result);
            } else if (root.data > k)
            {
                result.Add(root.data);
                FindPathHelper(root.left, k, result);
            }
        }
    }
}
