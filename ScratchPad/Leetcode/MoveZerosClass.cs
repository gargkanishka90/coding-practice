using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class MoveZerosClass
    {
        // nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0]
        public void MoveZeroes(int[] nums)
        {
            var startZeroIndex = -1;
            var nonZeroIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if(startZeroIndex >= 0)
                        Swap(nums, startZeroIndex++, i);
                }
                else
                {
                    if (startZeroIndex < 0) startZeroIndex = i;
                }
            }
        }

        private void Swap(int[] nums, int startZeroIndex, int p2)
        {
            var tmp = nums[startZeroIndex];
            nums[startZeroIndex] = nums[p2];
            nums[p2] = tmp;
        }
    }
}
