using System.Collections.Generic;

namespace ScratchPadTests.Leetcode
{
    public class FindAllDisappearedNumbers
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();

            var indexArray = new int[nums.Length + 1];

            for (var j = 1; j <= nums.Length; j++)
            {
                indexArray[j] = -1;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                indexArray[nums[i]] = nums[i];
            }

            for (var j = 1; j <= nums.Length; j++)
            {
                if (indexArray[j] == -1)
                {
                    result.Add(j);
                }
            }

            return result;
        }
    }
}