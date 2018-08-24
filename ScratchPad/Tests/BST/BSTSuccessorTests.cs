using System;
using NUnit.Framework;
using ScratchPad.BST;

namespace ScratchPad.Tests.BST
{
    [TestFixture]
    public static class BSTSuccessorTests
    {
        [Test]
        public static void FindInorderSuccessorTest()
        {
            var root = BSTUtilities.CreateSampleBSTWithLinkToParents();
            Console.WriteLine($"In-Order Successor of {root.left.data} is: {BSTSuccessor.FindInOrderSuccessor(root.left)}");
            Console.WriteLine($"In-Order Successor of {root.left.right.left.data} is: {BSTSuccessor.FindInOrderSuccessor(root.left.right.left)}");
            Console.WriteLine($"In-Order Successor of {root.left.right.right.data} is: {BSTSuccessor.FindInOrderSuccessor(root.left.right.right)}");
            Console.WriteLine($"In-Order Successor of {root.right.data} is: {BSTSuccessor.FindInOrderSuccessor(root.right)}");
            Console.WriteLine($"In-Order Successor of {root.left.left.data} is: {BSTSuccessor.FindInOrderSuccessor(root.left.left)}");
            Console.WriteLine($"In-Order Successor of {root.left.right.data} is: {BSTSuccessor.FindInOrderSuccessor(root.left.right)}");
        }
    }
}
