using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ScratchPad.Hashing;

namespace ScratchPad.Tests.Hashing
{
    class SingleNumberTest
    {
        [Test]
        public void SingleNumber_Test()
        {
            Assert.IsTrue(SingleNumber.Find(new []{2,2,1}) == 1);
        }
    }
}
