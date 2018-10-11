using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ScratchPadTests.Tests.StringTests
{
    [TestFixture]
    public class IntegerToEnglishWordTests
    {
        [Test]
        public void Test01()
        {
            var instance = new IntegerToEnglishWords();

            Assert.IsTrue(instance.NumberToWords(1).Contains("One"));
            Assert.IsTrue(instance.NumberToWords(12).Contains("Twelve"));

            Assert.IsTrue(instance.NumberToWords(75).Contains("Seventy Five"));
            Assert.IsTrue(instance.NumberToWords(60).Contains("Sixty"));
            Assert.IsTrue(instance.NumberToWords(88).Contains("Eighty Eight"));

            Assert.IsTrue(instance.NumberToWords(100).Contains("One Hundred"));
            Assert.IsTrue(instance.NumberToWords(500).Contains("Five Hundred"));
            Assert.IsTrue(instance.NumberToWords(123).Contains("One Hundred Twenty Three"));
            Assert.IsTrue(instance.NumberToWords(750).Contains("Seven Hundred Fifty"));

            Assert.IsTrue(instance.NumberToWords(1234).Contains("One Thousand Two Hundred Thirty Four"));
            Assert.IsTrue(instance.NumberToWords(12345).Contains("Twelve Thousand Three Hundred Forty Five"));
            Assert.IsTrue(instance.NumberToWords(123456).Contains("One Hundred Twenty Three Thousand Four Hundred Fifty Six"));
            Assert.IsTrue(instance.NumberToWords(1234567).Contains("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"));
            Assert.IsTrue(instance.NumberToWords(1234567891).Contains("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"));
        }
    }
}
