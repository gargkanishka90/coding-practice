using System;
using NUnit.Framework;
using ScratchPad.BST;
using ScratchPadTests.BinaryTree;

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

        [Test]
        public static void FindPathTest()
        {
            var tr = PreOrderToBST.Construct(new[] { 10, 5, 1, 7, 40, 50 });
            var path = BSTUtilities.FindPath(tr._root, 50);
            foreach (var i in path)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine();

            path = BSTUtilities.FindPath(tr._root, 7);
            foreach (var i in path)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine();
            path = BSTUtilities.FindPath(tr._root, 5);
            foreach (var i in path)
            {
                Console.Write(i + ",");
            }

        }

        [Test]
        public static void LcaTest()
        {
            var tr = PreOrderToBST.Construct(new[] { 10, 5, 1, 7, 40, 50 });
            Console.WriteLine("7 and 50: " + LowestCommonAncestorBST.FindLca(tr._root, new BSTNode(7), new BSTNode(50)));
            Console.WriteLine("7 and 1: " + LowestCommonAncestorBST.FindLca(tr._root, new BSTNode(7), new BSTNode(1)));
            Console.WriteLine("1 and 10: " + LowestCommonAncestorBST.FindLca(tr._root, new BSTNode(1), new BSTNode(10)));
            Console.WriteLine("7 and 40: " + LowestCommonAncestorBST.FindLca(tr._root, new BSTNode(7), new BSTNode(40)));
            Console.WriteLine("50 and 40: " + LowestCommonAncestorBST.FindLca(tr._root, new BSTNode(50), new BSTNode(40)));
        }

        [Test]
        public static void FindCeilBSTTest()
        {
            var tr = PreOrderToBST.Construct(new[] { 8,4,2,6,12,10,14 });

            for (var i = 0; i < 16; i++)
            {
                Console.WriteLine($"{i} : " + FloorAndCeilBST.FindCeilNode(tr._root, i)?.data);
            }
            
        }

        
    }
}
