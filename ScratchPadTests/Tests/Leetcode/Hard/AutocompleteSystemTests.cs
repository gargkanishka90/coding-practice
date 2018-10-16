using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Leetcode.Hard;

namespace ScratchPadTests.Tests.Leetcode.Hard
{
    [TestFixture]
    public class AutocompleteSystemTests
    {
        [Test]
        public void Test01()
        {
            var instance = new AutocompleteSystem(new [] {"i love you", "island", "ironman", "i love leetcode"}, new []{5, 3, 2, 2});
            var hgki = instance.Input('d');
        }
    }
}
