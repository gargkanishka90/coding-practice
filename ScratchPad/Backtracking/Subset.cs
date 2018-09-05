using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class Subset
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length == 0) return result;
            SubsetHelper(new List<int>(), result, 0, nums);
            return result;
        }

        private void SubsetHelper(List<int> partial, IList<IList<int>> result, int start, int[] nums)
        {
            result.Add(new List<int>(partial));
            for (var i = start; i < nums.Length; i++)
            {
                partial.Add(nums[i]);
                SubsetHelper(partial, result, i + 1, nums);
                partial.RemoveAt(partial.Count - 1);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
