using NUnit.Framework;
using ScratchPad.String;

namespace ScratchPadTests
{
    [TestFixture]
    public class StringIntegerConvertTests
    {
        [Test]
        public void Test01()
        {
            var instance = new StringIntegerConvert();
            Assert.AreEqual(1234, instance.StringToInteger("1234"));
            Assert.AreEqual(-1234, instance.StringToInteger("-1234"));
            Assert.AreEqual(0, instance.StringToInteger("0"));
            Assert.AreEqual(-1, instance.StringToInteger("-1"));
            Assert.AreEqual(1, instance.StringToInteger("1"));

            Assert.AreEqual("1", instance.IntegerToString(1));
            Assert.AreEqual("-1", instance.IntegerToString(-1));
            Assert.AreEqual("123", instance.IntegerToString(123));
            Assert.AreEqual("-123", instance.IntegerToString(-123));
        }
    }
}