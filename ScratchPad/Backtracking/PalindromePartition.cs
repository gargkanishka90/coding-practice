using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class PalindromePartition
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            if (string.IsNullOrWhiteSpace(s))
            {
                result.Add(new List<string>());
                return result;
            }

            Helper(s, 0, result, new List<string>());
            return result;
        }

        private void Helper(string s, int start, List<IList<string>> result, List<string> partial)
        {
            if (start == s.Length)
            {
                result.Add(new List<string>(partial));
                //partial = new List<string>();
            }
            else
            {
                for (var i = start; i < s.Length; ++i)
                {    
                    if (IsPalindrome(s.ToCharArray(), start, i))
                    {
                        var temp = s.Substring(start, i - start + 1);
                        partial.Add(temp);
                        Helper(s, i + 1, result, partial);
                        partial.RemoveAt(partial.Count - 1);
                    }
                }
            }
        }

        public bool IsPalindrome(char[] s, int low, int high)
        {
            while (low < high)
                if (s[low++] != s[high--]) return false;
            return true;
        }
    }
}
