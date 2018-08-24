using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ScratchPad.String
{
    public class GenerateAllPermutations
    {
        public static List<string> GetPermutations(string thisString)
        {
            var myResult = new List<string>();
            if (thisString.Length == 0)
            {
                myResult.Add("");
                return myResult;
            }

                var first = thisString[0];
                var subresults = GetPermutations(thisString.Substring(1));
                foreach (var subresult in subresults)
                {
                    for (var j = 0; j <= subresult.Length; ++j)
                    {
                        myResult.Add(subresult.Substring(0,j) + first + subresult.Substring(j));
                    }
                }
            return myResult;
        }

        public static IList<string> FindPermutations(string str)
        {
            var result = new List<string>();

            if (str.Length == 0)
            {
                result.Add("");
                return result;
            }
            else {
                var firstChar = str[str.Length-1];
                var subWords = FindPermutations(str.Substring(0, str.Length-1));
                foreach (var word in subWords)
                {
                    for (var pos = 0; pos <= word.Length; pos++)
                    {
                        result.Add(word.Substring(0, pos) + firstChar + word.Substring(pos));
                    }
                }
            }
            return result;
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return result;

            Permute(nums, new List<int>(), result);
            return result;
        }

        private static void Permute(int[] nums, List<int> partialList, IList<IList<int>> result)
        {
            if (partialList.Count == nums.Length)
            {
                result.Add(new List<int>(partialList));
                return;
            }
            else
            {
                foreach (var num in nums)
                {
                    if (partialList.Contains(num))
                        continue;
                    partialList.Add(num);
                    Permute(nums, partialList, result);
                    partialList.RemoveAt(partialList.Count - 1);
                }
            }
        }

        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return result;

            PermuteUnique(nums, new List<int>(), result, new bool[nums.Length]);
            return result;
        }

        // [1,1,2] -> [[1,1,2],[1,2,1],[2,1,1]]
        private static void PermuteUnique(int[] nums, List<int> partialList, IList<IList<int>> result, bool[] memory)
        {
            if (partialList.Count == nums.Length)
            {
                result.Add(new List<int>(partialList));
            }
            else
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    if(memory[i] || i > 0 && nums[i] == nums[i-1] && !memory[i-1]) continue;
                    partialList.Add(nums[i]);
                    memory[i] = true;
                    PermuteUnique(nums, partialList, result, memory);
                    partialList.RemoveAt(partialList.Count - 1);
                    memory[i] = false;
                }
            }
        }
    }
}