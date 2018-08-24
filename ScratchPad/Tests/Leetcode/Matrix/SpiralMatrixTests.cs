using System;
using System.Collections.Generic;
using NUnit.Framework;
using ScratchPad.Leetcode.Matrix;

namespace ScratchPad.Tests.Leetcode.Matrix
{
    [TestFixture]
    public class SpiralMatrixTests
    {
        [Test]
        public void Test01()
        {
            var grid = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            var instance = new SpiralMatrix();
            var res = instance.PrintSpiral(grid);
           // Assert.AreEqual(new []{ 1, 2, 3, 6, 9, 8, 7, 4, 5 }, res);

            grid = new[,]
            {
                {1, 2, 3},
                {4, 5, 6}
            };
            res = instance.PrintSpiral(grid);
            Assert.AreEqual(new[] { 1, 2, 3, 6, 5, 4 }, res);
        }

        [Test]
        public void Test02()
        {
            var instance = new SpiralMatrix();
            var res = instance.FillMatrix(3);
            res = instance.FillMatrix(4);
        }
    }
}
