using System;
using NUnit.Framework;
using ScratchPad.BinaryTree;
using ScratchPad.Utils;

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
            var root = TreeUtils.CreateRandomTree();
            LevelOrderTraversal.LeverOrderTraversal2(root);
        }

        [Test]
        public static void FindPathTest()
        {
            var root = TreeUtils.CreateRandomTree();
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
    }
}