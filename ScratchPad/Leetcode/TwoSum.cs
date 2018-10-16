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

        public static int[] TargetIndices(int[] numbers, int target)
        {
            var indexes = new int[2];

            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    indexes[0] = left + 1;
                    indexes[1] = right + 1;
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return indexes;
        }
    }
}