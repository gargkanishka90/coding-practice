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

        [Test]
        public void OneEditApartTest01()
        {
            var instance = new StringEdit();
            Assert.IsFalse(instance.OneEditApart("cat", "dog"));
            Assert.IsFalse(instance.OneEditApart("cat", "act"));
            Assert.IsTrue(instance.OneEditApart("cat", "cats"));
            Assert.IsTrue(instance.OneEditApart("cat", "cut"));
            Assert.IsTrue(instance.OneEditApart("cat", "cast"));
            Assert.IsTrue(instance.OneEditApart("cat", "at"));
            Assert.IsTrue(instance.OneEditApart("1203", "1213"));

            instance = new StringEdit();
            Assert.IsFalse(instance.OneEditApartEfficient("cat", "dog"));
            Assert.IsFalse(instance.OneEditApartEfficient("cat", "act"));
            Assert.IsTrue(instance.OneEditApartEfficient("cat", "cats"));
            Assert.IsTrue(instance.OneEditApartEfficient("cat", "cut"));
            Assert.IsTrue(instance.OneEditApartEfficient("cat", "cast"));
            Assert.IsTrue(instance.OneEditApartEfficient("cat", "at"));
            Assert.IsTrue(instance.OneEditApartEfficient("1203", "1213"));
        }

        [Test]
        public void LongestPalindromicSubstringTest()
        {
            var instance = new LongestPalindromicSubstring();
            Assert.AreEqual("bb", instance.Find("abbd"));
            Assert.AreEqual("bab", instance.Find("cbabd"));
        }
    }

    
}