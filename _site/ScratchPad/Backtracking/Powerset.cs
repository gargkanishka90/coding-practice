using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class Powerset
    {
        public static IList<IList<int>> Generate(int[] nums)
        {
            var n = nums.Length;

            var result = new List<IList<int>>();

            for (var i = 0; i < (1 << n); i++)
            {
                var sub = new List<int>();
                for (var j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        sub.Add(nums[j]);
                    }
                }
                result.Add(sub);
            }
            return result;
        }

        public IList<IList<int>> Generate1(int[] nums)
        {
            var result = new List<IList<int>>();
            result = SubsetHelper(nums, 0).ToList();
            return result;
        }

        private IList<IList<int>> SubsetHelper(int[] nums, int start)
        {
            IList<IList<int>> allSubsets;
            if (nums.Length == start)
            {
                allSubsets = new List<IList<int>>();
                allSubsets.Add(new List<int>());
            }
            else
            {
                allSubsets = SubsetHelper(nums, start + 1);
                var current = nums[start];
                var tempSubSets = new List<List<int>>();
                foreach (var sub in allSubsets)
                {
                    var t = new List<int>();
                    t.AddRange(sub);
                    t.Add(current);
                    tempSubSets.Add(t);
                }
                allSubsets.ToList().AddRange(tempSubSets);
            }
            return allSubsets;
        }
    }
}
