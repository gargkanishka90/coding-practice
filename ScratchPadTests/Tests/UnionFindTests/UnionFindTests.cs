using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.UnionFind;

namespace ScratchPadTests.Tests.UnionFindTests
{
    [TestFixture]
    public class UnionFindTests
    {
        [Test]
        public void Test01()
        {
            var uf = new UnionFind(3);
            var edges = new[,] {{0, 1}, {1, 2}, {0, 2}};
        }
    }
}
