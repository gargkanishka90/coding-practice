using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.DynamicProgramming;

namespace ScratchPadTests.Tests.DynamicProgramming
{
    [TestFixture]
    public class ScoreCombinationTests
    {
        [Test]
        public void Test01()
        {
            var instance = new ScoreCombinations();
            var res = instance.FindNumberOfCombinations(12, new[] {2, 3, 7});
        }
    }
}
