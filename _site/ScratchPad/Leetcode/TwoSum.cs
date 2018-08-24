using System;
using System.Collections.Generic;

namespace ScratchPadTests.Leetcode
{   /*
        Question 1:  Given an array of integers, return indices of the two 
        numbers such that they add up to a specific target.
    */
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