using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class Permutations
    {
        public IEnumerable<string> FindAllStringPermutations(string input)
        {
            var result = new List<string>();
            if (string.IsNullOrWhiteSpace(input))
                return result;
            StringPermutationHelper(input.ToCharArray(), 0, "", result);
            return result;
        }

        private void StringPermutationHelper(char[] input, int start, string partial, List<string> result)
        {
            if (start == input.Length)
            {
                result.Add(partial);
            }
            else
            {
                for (var i = start; i < input.Length; i++)
                {
                    Swap(input, start, i);
                    StringPermutationHelper(input, start + 1, partial + input[start], result);
                    Swap(input, start, i);
                }
            }
        }

        private void Swap(char[] s, int pos1, int pos2)
        {
            var temp = s[pos1];
            s[pos1] = s[pos2];
            s[pos2] = temp;
        }

        public IList<IList<int>> FindAllIntegerPermutations(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length == 0)
            {
                result.Add(new List<int>());
                return result;
            }
            IntegerPermutationHelper(nums, 0, result);

            return result;
        }

        private void IntegerPermutationHelper(int[] nums, int start, List<IList<int>> result)
        {
            if (start + 1 == nums.Length)
            {
                result.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i < nums.Length; ++i)
                {
                    Swap(nums, i, start);
                    IntegerPermutationHelper(nums, start + 1, result);
                    Swap(nums, i, start);
                }
            }
        }

        private void Swap(int[] s, int pos1, int pos2)
        {
            var temp = s[pos1];
            s[pos1] = s[pos2];
            s[pos2] = temp;
        }

        public string GetPermutation(int n, int k)
        {
            var nums = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                nums.Append(i + 1);
            }

            var result = new List<string>();
            FindKthPermutation(nums.ToString().ToCharArray(), k, result, 0, "");
            return result[k-1];
        }

        private void FindKthPermutation(char[] nums, int k, List<string> current, int start, string partial)
        {
            if (partial.Length == nums.Length)
            {
                current.Add(partial);
            }
            else
            {
                for (var i = start; i < nums.Length; i++)
                {
                    if(current.Count == k) break;
                    Swap(nums, start, i);
                    FindKthPermutation(nums, k, current, start + 1, partial + nums[start]);
                    Swap(nums, start, i);
                }
            }
        }
    }
}
