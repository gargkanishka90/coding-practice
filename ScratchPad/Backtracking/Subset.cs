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
            BackTrackSubset(nums, result, 0);
            return result;
        }

        private void BackTrackSubset(int[] nums, IList<IList<int>> result, int left)
        {
            if (left == nums.Length - 1)
            {
                return;
            }
        } 
    }
}
