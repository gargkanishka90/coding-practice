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
    }
}
