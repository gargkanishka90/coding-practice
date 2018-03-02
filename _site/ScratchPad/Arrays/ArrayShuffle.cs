using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Arrays
{
    public class ArrayShuffle
    {
        int[] nums;
        int[] original;

        public ArrayShuffle(int[] nums)
        {
            this.nums = nums;
            Array.Copy(nums, original, nums.Length);
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            nums = original;
            return nums;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            var copy = new int[nums.Length];
            Array.Copy(nums, copy, original.Length);
            var rand = new Random();
            for (var i = copy.Length - 1; i >= 1; i--)
            {
                var j = rand.Next(0, i - 1);
                swap(nums, j, i);
            }
            return copy;
        }

        private void swap(int[] arr, int j, int i)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
