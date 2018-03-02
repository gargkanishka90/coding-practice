using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Hashing
{
    public class ContainsDuplicate
    {
        public static bool Check(int[] nums)
        {
            if (nums.Length == 0) return false;

            var seen = new HashSet<int>();

            foreach (var num in nums)
            {
                if (seen.Contains(num))
                {
                    return false;
                }
                seen.Add(num);
            }
            return true;
        }
    }
}