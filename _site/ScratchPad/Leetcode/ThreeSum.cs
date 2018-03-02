using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class ThreeSumClass
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);

            for (var index = 0; index < nums.Length - 2; index++)
            {
                var currentItem = nums[index];
                if (index > 0)
                {
                    var previousItem = nums[index - 1];
                    if (currentItem == previousItem)
                        continue;
                }

                var pairs = NegativeSumPair(nums, index);

                foreach (var pair in pairs)
                {
                    result.Add(new List<int> { currentItem, pair[0], pair[1] });
                }
            }
            return result;
        }

        private List<List<int>> NegativeSumPair(int[] nums, int currentIndex)
        {
            var sumTarget = -1 * nums[currentIndex];
            var begin = currentIndex + 1;
            var end = nums.Length - 1;
            var result = new List<List<int>>();

            while (begin < end)
            {
                var tempSum = nums[begin] + nums[end];
                if (tempSum < sumTarget)
                {
                    begin++;
                } else if (tempSum > sumTarget)
                {
                    end--;
                }
                else
                {
                    
                    result.Add(new List<int> { nums[begin], nums[end] });
                    begin++;
                    end--;
                    
                }
            }
            return result;
        }
    }
}
