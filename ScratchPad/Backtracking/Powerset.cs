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
    }
}
