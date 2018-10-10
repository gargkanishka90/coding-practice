using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ScratchPad.Leetcode;
using ScratchPad.SegmentTree;

namespace ScratchPadTests.Tests.SegmentTreeTests
{
    [TestFixture]
    public class SegmentTreeTests
    {
        [Test]
        public static void ConstructSegTreeTest_Array_Not_Power_Of_2()
        {
            var segTree = new SegmentTree();
            var arr = new[] {1, 2, 3, 4, 5, 6};
            var size = segTree.FindSegmentTreeSize(arr.Length);
            var segArr = new int[2*size - 1];
            segTree.ConstructSegTree(segArr, arr , 0, arr.Length - 1, 0);

            //Assert
            Assert.AreEqual(21, segArr[0]);
        }

        [Test]
        public static void ConstructSegTreeTest_Array_Power_Of_2()
        {
            var segTree = new SegmentTree();
            var arr = new[] { 1, 2, 3, 4, 5, 6 , 7, 8};
            var size = segTree.FindSegmentTreeSize(arr.Length);
            var segArr = new int[2 * size - 1];
            segTree.ConstructSegTree(segArr, arr, 0, arr.Length - 1, 0);

            //Assert
            Assert.AreEqual(36, segArr[0]);
        }

        [Test]
        public static void QuerySegTreeTest_Array_Power_Of_2()
        {
            var segTree = new SegmentTree();
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var sumRange = segTree.FindSumRange(arr, 3, 7);

            //Assert
            Assert.AreEqual(30, sumRange);
        }

        [Test]
        public static void NumArrayTest()
        {
            //var segTree = new NumArray(new []{9, -8});
            //segTree.Update(0, 3);
            //segTree.SumRange(1, 1);
            //segTree.SumRange(0, 1);
            //segTree.Update(1, -3);
            //segTree.SumRange(0, 1);
        }
    }
}
