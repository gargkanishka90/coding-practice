using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Hashing
{
    public class KMostFrequently
    {
        public static IList<int> Find(int[] nums, int k)
        {
            var dict = new Dictionary<int,int>();

            foreach (var num in nums)
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
            var result = new List<int>();

            foreach (var pair in dict.OrderBy(kv => -kv.Value))
            {
                result.Add(pair.Key);
                if (result.Count == k)
                {
                    break;
                }
            }

            return result;
        } 
    }
}