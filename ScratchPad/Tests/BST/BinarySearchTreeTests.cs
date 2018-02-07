using System;
using NUnit.Framework;
using ScratchPad.BST;

namespace ScratchPad.Tests.BST
{
    [TestFixture]
    public class BinarySearchTreeTests
    {
        [Test]
        public static void InOrderBSTTraversalTest()
        {
            var tree = BSTUtilities.CreateRandomBST();
            tree.InOrderTraversal();
        }

        [Test]
        public static void SearchBstTest()
        {
            var tree = BSTUtilities.CreateRandomBST();
            var test = BSTUtilities.Search(tree._root, 99);
            Console.WriteLine(test?.data ?? -1);
            test = BSTUtilities.Search(tree._root, 70);
            Console.WriteLine(test?.data);
        }

        [Test]
        public static void GetMinimumValueBstTest()
        {
            var tree = BSTUtilities.CreateRandomBST();
            var test = BSTUtilities.Search(tree._root, 70);
            tree.InOrderTraversal();
            Console.WriteLine();
            Console.WriteLine(BSTUtilities.GetMinimumValue(tree._root));
            Console.WriteLine(BSTUtilities.GetMinimumValue(tree._root.right));
        }

        [Test]
        public static void DeleteKeyFromBstTest()
        {
            var tree = BSTUtilities.CreateRandomBST();
            var test = BSTUtilities.Search(tree._root, 70);
            tree.InOrderTraversal();
            Console.WriteLine();
            var t = BSTUtilities.Delete(tree._root, 70);
            //Console.WriteLine(BSTUtilities.GetMinimumValue(tree._root.right));
        }

        [Test]
        public static void PreorderToBSTTest()
        {
            var tr = PreOrderToBST.Construct(new[] {10, 5, 1, 7, 40, 50});
            tr.InOrderTraversal();
        }
    }
}
