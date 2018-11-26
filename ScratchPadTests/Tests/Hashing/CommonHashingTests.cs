using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Hashing;

namespace ScratchPadTests.Tests.Hashing
{
    [TestFixture]
    public class CommonHashingTests
    {
        //[Test]
        //public void Test01()
        //{
        //    var cache = new LFUCache(2 /* capacity */ );

        //    cache.Put(1, 1);
        //    cache.Put(2, 2);
        //    Assert.AreEqual(1, cache.Get(1));       // returns 1
        //    cache.Put(3, 3);    // evicts key 2
        //    Assert.AreEqual(-1,cache.Get(2));       // returns -1 (not found)
        //    Assert.AreEqual(3, cache.Get(3));       // returns 3.
        //    cache.Put(4, 4);    // evicts key 1.
        //    Assert.AreEqual(-1, cache.Get(1));       // returns -1 (not found)
        //    Assert.AreEqual(3,cache.Get(3));       // returns 3
        //    Assert.AreEqual(4, cache.Get(4));       // returns 4
        //}
    }
}
