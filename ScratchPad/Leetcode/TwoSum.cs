using System;
using System.Collections.Generic;

namespace ScratchPadTests.Leetcode
{
    public static class TwoSum
    {
        public static int[] GetIndices(int[] arr, int sum)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(sum - arr[i]))
                {
                    return new[] { dict[sum - arr[i]], i };
                }
                dict[arr[i]] = i;
            }
            throw new Exception("Sum does not exist");
        }
    }
}