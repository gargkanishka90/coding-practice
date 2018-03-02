using NUnit.Framework;
using ScratchPad.Hashing;

namespace ScratchPad
{
    public class ValidAnagramTest
    {
        [Test]
        public void ValidAnagram_Test()
        {
            var result1 = ValidAnagram.IsValid("anagram", "nagamar");
            Assert.IsTrue(result1);

            var result2 = ValidAnagram.IsValid("a", "b");
            Assert.IsFalse(result2);

            var result3 = ValidAnagram.IsValid("", "");
            Assert.IsTrue(result3);

            var result4 = ValidAnagram.IsValid("", "b");
            Assert.IsFalse(result4);

            var result5 = ValidAnagram.IsValid("a", "");
            Assert.IsFalse(result5);
        } 
    }
}