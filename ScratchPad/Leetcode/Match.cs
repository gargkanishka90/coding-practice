using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class Match
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == "" && needle == "") return 0;

            if (needle == "" && haystack.Length > 0) return 0;

            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle)) return -1;

            if (needle.Length > haystack.Length) return -1;

            var firstCharPos = new List<int>();

            for (var i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    firstCharPos.Add(i);
                }
            }

            foreach (var pos in firstCharPos)
            {
                if (haystack.Length - pos + 1 > needle.Length)
                {
                    if (TryMatch(pos, haystack, needle))
                    {
                        return pos;
                    }
                }
            }
            return -1;
        }

        private bool TryMatch(int start, string word, string pattern)
        {
            for (var j = 0; j < pattern.Length; j++)
            {
                if (start + j < word.Length && word[start + j] != pattern[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
