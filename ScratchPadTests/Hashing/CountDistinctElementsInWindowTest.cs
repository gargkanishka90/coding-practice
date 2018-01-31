using NUnit.Framework;
using ScratchPadTests.Hashing;

namespace ScratchPad.Hashing
{
    public class CountDistinctElementsInWindowTest
    {
        [Test]
        public void Count()
        {
            int[] nums = {1, 2, 1, 3, 4, 2, 3};
            CountDistinctElementsInWindow.Count(nums, 4);

            var test = "The Academy";
            CountDistinctElementsInWindow.CountLetters(test);

            var t = CountDistinctElementsInWindow.CheckDigit("87815811023456421");

            var w = CountDistinctElementsInWindow.CheckCode("4", "87815811023456421");
        } 
    }
}