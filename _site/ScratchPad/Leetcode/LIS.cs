using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class LIS
    {
        public static int LISLength(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            return LISBruteForce(nums, int.MinValue, 0);
        }

        public static int LISBruteForce(int[] nums, int prev, int curIdx)
        {
            if (curIdx == nums.Length)
                return 0;

            var taken = 0;
            if (nums[curIdx] > prev)
            {
                taken = 1 + LISBruteForce(nums, nums[curIdx], curIdx + 1);
            }

            var nottaken = LISBruteForce(nums, prev, curIdx + 1);
            return Math.Max(taken, nottaken);
        }
    }
}
