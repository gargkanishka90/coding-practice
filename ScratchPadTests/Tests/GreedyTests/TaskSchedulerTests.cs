using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Greedy;

namespace ScratchPadTests.Tests.GreedyTests
{
    [TestFixture]
    public class TaskSchedulerTests
    {
        [Test]
        public void Test01()
        {
            var instance = new TaskSchedulerCPU();
            var t = instance.FindMinCycles(new char[] {'A', 'A', 'A', 'B', 'B', 'B',}, 2);
        }
    }
}
