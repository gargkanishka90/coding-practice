using System;
using System.Collections.Generic;

namespace ScratchPad.Leetcode.Patterns.MinimumWindow
{
    public class PermutationInAString567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1)
               || string.IsNullOrWhiteSpace(s2)
               || s1.Length == 0
               || s2.Length == 0
               || s1.Length > s2.Length)
            {
                return false;
            }

            var map = new Dictionary<char, int>();
            foreach(var ch in s1){
                if(!map.ContainsKey(ch)){
                    map[ch] = 0;
                }
                map[ch]++;
            }

            var b = 0;
            var e = 0;
            var letters = map.Keys.Count;
            var permLength = s1.Length;

            while(e < s2.Length){
                if (map.ContainsKey(s2[e]))
                {
                    map[s2[e]]--;
                    if (map[s2[e]] == 0)
                        letters--;
                }

                e++;

                while(letters == 0){
                    if (e - b == permLength)
                        return true;

                    if(map.ContainsKey(s2[b])){
                        map[s2[b]]++;
                        if (map[s2[b]] > 0)
                            letters++;
                    }
                    b++;
                }
            }

            return false;
        }
    }
}
