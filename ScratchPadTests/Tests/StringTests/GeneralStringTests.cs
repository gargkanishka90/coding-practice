using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.String;

namespace ScratchPadTests.Tests.StringTests
{
    [TestFixture]
    public class GeneralStringTests
    {
        [Test]
        public void LookAndSayTest01()
        {
            var instance = new LookAndSay();
            var res = instance.Generate(4);
        }
    }
}