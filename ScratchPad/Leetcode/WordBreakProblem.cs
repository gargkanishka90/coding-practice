using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class WordBreakProblem
    {
        // { i, like, sam, sung, samsung, mobile, ice, cream, icecream, man, go, mango

        // Word Break with Memoization
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            var dict = new HashSet<string>(wordDict);
            var memory = new Dictionary<string, bool>();

            return CanBreak(s, memory, dict);
        }

        private bool CanBreak(string s, IDictionary<string, bool> memory, ISet<string> dict)
        {
            if (s == "")
                return true;

            if (!memory.ContainsKey(s))
            {
                for (var i = 1; i <= s.Length; i++)
                {
                    var temp = s.Substring(0, i);
                    var substringFound = CanBreak(s.Substring(i), memory, dict);

                    memory[s.Substring(i)] = substringFound;

                    if (dict.Contains(temp) && substringFound)
                    {
                        return true;
                    }
                }
                return false;
            }

            return memory[s];
        }

        // word break using recursion
        public static bool WordBreak1(string s, IList<string> wordDict)
        {
            var set = new HashSet<string>(wordDict);
            if (s == "") return true;

            return WordBreakRec(s, set);
        }

        public static bool WordBreakRec(string input, HashSet<string> set)
        {
            if (input.Length == 0)
            {
                return true;
            }

            for (var idx = 1; idx <= input.Length; idx++)
            {
                var temp = input.Substring(0, idx);
                if (set.Contains(temp) && WordBreakRec(input.Substring(idx), set))
                {
                    return true;
                }
            }
            return false;
        }

        // The idea here is to 
        public static bool WordBreakDP(string s, IList<string> wordDict){
            var set = new HashSet<string>(wordDict);
            if (s == "") return true;

            var dp = new bool[s.Length + 1];
            dp[0] = true;

            for (var len = 1; len <= s.Length; len++){
                for (var i = 0; i < len; i++){
                    if(dp[i] && set.Contains(s.Substring(i, len))){
                        dp[len] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
