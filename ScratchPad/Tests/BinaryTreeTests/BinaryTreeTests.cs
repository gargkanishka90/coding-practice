using System;
using NUnit.Framework;
using ScratchPad.BinaryTree;
using ScratchPadTests.BinaryTree;

namespace ScratchPad
{
    [TestFixture]
    public class BinaryTreeTests
    {
        [Test]
        public static void PreOrderTest()
        {
            var root = TreeHelpers.CreateRandomTree();
            TreeTraveral.PreOrderTraverse(root);
        }

        [Test]
        public static void PostOrderTest()
        {
            var root = TreeHelpers.CreateRandomTree();
            TreeTraveral.PostOrderTraverse(root);
        }

        [Test]
        public static void InOrderTest()
        {
            var root = TreeHelpers.CreateRandomTree();
            TreeTraveral.InOrderTraverse(root);
        }

        [Test]
        public static void LevelOrderTest()
        {
            var root = TreeHelpers.CreateRandomTree();
            TreeTraveral.LeverOrderTraversal(root);
        }

        [Test]
        public static void FindPathTest()
        {
            var root = TreeHelpers.CreateRandomTree();
            var path = TreeHelpers.FindPath(root, 810);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }

            Console.WriteLine();
            path = TreeHelpers.FindPath(root, 58);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = TreeHelpers.FindPath(root, 8);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = TreeHelpers.FindPath(root, 6);

            foreach (var node in path)
            {
                Console.Write(node.data + " , ");
            }
            Console.WriteLine();

            path = TreeHelpers.FindPath(root, 77);

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
            var tr = TreeHelpers.CreateRandomTree();

            var leaves = TreeHelpers.ComputeLeaves(tr);

        }
    }
}