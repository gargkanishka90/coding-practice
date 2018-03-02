using System;
using NUnit.Framework;
using ScratchPad.BinaryTree;
using ScratchPad.BST;
using ScratchPad.Utils;
using ScratchPadTests.BinaryTree;

namespace ScratchPad
{
    [TestFixture]
    public class BinaryTreeTests
    {
        [Test]
        public static void PreOrderTest()
        {
            var root = TreeUtils.CreateRandomTree();
            PrintUtils.PrintList(PreOrderTraversal.PreOrderIterative(root));
        }

        [Test]
        public static void PostOrderTest()
        {
            var root = TreeUtils.CreateRandomTree();
            PrintUtils.PrintList(PostOrderTraversal.PostOrderIterative(root));
        }

        [Test]
        public static void InOrderTest()
        {
            var root = TreeUtils.CreateRandomTree();
            InOrderTraversal.InOrderTraverselIterative(root);
            Console.WriteLine();
            InOrderTraversal.InOrderTraverselIterative(root);
        }

        [Test]
        public static void LevelOrderTest()
        {
            var root = SortedArrayToBinarySearchTree.SortedArrayToBST(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15});
            //LevelOrderTraversal.LevelOrderTraversalIterative1(root);
            Console.WriteLine();
            //LevelOrderTraversal.LevelOrderTraversalIterative3(root);
            LevelOrderTraversal.LevelOrderBottom(root);
        }

        [Test]
        public static void FindPathTest()
        {
            var node1 = new TreeNode(6);
            var node2 = new TreeNode(8);
            var node3 = new TreeNode(10);
            var node4 = new TreeNode(16);
            var node5 = new TreeNode(58);
            var node6 = new TreeNode(810);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;

            var root = node1;
            var path = BinaryTreeLca.FindPath(root, 810);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }

            Console.WriteLine();
            path = BinaryTreeLca.FindPath(root, 58);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = BinaryTreeLca.FindPath(root, 8);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = BinaryTreeLca.FindPath(root, 6);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = BinaryTreeLca.FindPath(root, 77);

            if (path != null)
            {
                foreach (var node in path)
                {
                    Console.Write(node.data + " , ");
                }
            }
            else
            {
                Console.WriteLine("No Path Exists.");
            }
            Console.WriteLine();
        }

        [Test]
        public static void ComputeLeavesTest()
        {
            var tr = TreeUtils.CreateRandomTree();

            var leaves = BinaryTreeComputeLeaves.ComputeLeaves(tr);
            PrintUtils.PrintList(leaves);
        }

        [Test]
        public static void SameTreeTest()
        {
            var root1 = TreeUtils.CreateRandomTree();
            var root2 = TreeUtils.CreateRandomTree();
            Assert.AreEqual(true, BinaryTreeSame.IsSameTreeIterative(root1, root2));
            Assert.AreEqual(true, BinaryTreeSame.IsSameTreeRecursive(root1, root2));

            var root3 = SortedArrayToBinarySearchTree.SortedArrayToBST(new[] { 1, 2, 3 });
            var root4 = SortedArrayToBinarySearchTree.SortedArrayToBST(new[] { 1, 3, 2 });
            Assert.AreEqual(false, BinaryTreeSame.IsSameTreeIterative(root3, root4));
            Assert.AreEqual(false, BinaryTreeSame.IsSameTreeRecursive(root3, root4));
        }

        [Test]
        public static void IsBinaryTreeBalanced(){
            var root = TreeUtils.CreateRandomTree();
            Console.WriteLine(TreeUtils.IsBalanced(root));
        }

        [Test]
        public static void InvertBinaryTreeTest()
        {
            var root = TreeUtils.CreateRandomTree();
            TreeUtils.PrintTree(root);
            Console.WriteLine();
            root = InvertBinaryTree.InvertTree(root);
            //Assert.AreEqual(root.left.data, inverted.right.data);
            //Assert.AreEqual(root.right.data, inverted.left.data);

            TreeUtils.PrintTree(root);
        }
    }
}