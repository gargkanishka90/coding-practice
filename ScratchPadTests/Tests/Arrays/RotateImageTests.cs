using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Arrays;

namespace ScratchPadTests.Tests.Arrays
{
    [TestFixture]
    public class RotateImageTests
    {
        [Test]
        public void Test01()
        {
            var instance = new RotateImage();
            var image = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            var rotated = new int[,]
            {
                { 7, 4, 1},
                { 8, 5, 2 },
                { 9, 6, 3 }
            };
            var rotatedImage = instance.Rotate(image);
            //Assert.AreEqual(rotated, rotatedImage);
        }
    }
}
