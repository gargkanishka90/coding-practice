using System;
using System.Collections.Generic;

namespace ScratchPad.Leetcode.Patterns.MinimumWindow
{
    public class FindAnagramPositions
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();

            if(string.IsNullOrWhiteSpace(s)
               || string.IsNullOrWhiteSpace(p)
               || s.Length == 0
               || p.Length == 0
               || p.Length > s.Length)
            {
                return result;
            }

            var table = new Dictionary<char, int>();
            foreach(var ch in p){
                if (!table.ContainsKey(ch))
                    table[ch] = 0;
                table[ch]++;
            }

            var b = 0;
            var e = 0;
            var pLen = p.Length;
            var letters = table.Keys.Count;

            while(e < s.Length){
                if(table.ContainsKey(s[e])){
                    table[s[e]]--;

                    if(table[s[e]] == 0){
                        letters--;
                    }
                }

                e++;

                while(letters == 0){
                    // found an anagram.
                    if(e - b == pLen)
                        result.Add(b);

                    // move start pointer ahead.
                    if(table.ContainsKey(s[b])){
                        table[s[b]]++;
                        if(table[s[b]] > 0){
                            letters++;
                        }
                    }
                    b++;
                }
            }

            return result;
        }
    }
}
