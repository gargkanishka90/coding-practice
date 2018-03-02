using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class MissingClass
    {
        // Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
        public int MissingNumber(int[] nums)
        {
            var size = nums.Length;

            var sumOfN = size * (size + 1) / 2;

            var sumOfGiven = nums.Sum();

            return sumOfN - sumOfGiven;
        }
    }
}
