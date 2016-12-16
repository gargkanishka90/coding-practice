using NUnit.Framework;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTreeTests
{
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
    }
}