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
        } 
    }
}