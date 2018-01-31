using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class IntersectClass
    {
        // Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var common = new List<int>();

            var dict = new Dictionary<int,int>();

            foreach (var num in nums1)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] += 1;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var num in nums2)
            {
                if (dict.ContainsKey(num))
                {
                    common.Add(num);
                    dict[num] -= 1;
                    if (dict[num] == 0)
                    {
                        dict.Remove(num);
                    }
                }
            }
            return common.ToArray();
        }
    }
}
