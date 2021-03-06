﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class WordBreakProblem
    {
        // { i, like, sam, sung, samsung, mobile, ice, cream, icecream, man, go, mango
        // To Search: ilike
        //public static IList<string> WordBreak1(string input, string[] dictionary)
        //{
        //    var result = new HashSet<string>();
        //    var set = new HashSet<string>();
        //    foreach (var entry in dictionary)
        //    {
        //        set.Add(entry);
        //    }
        //    var memory = new Dictionary<string, bool>();
        //    //WordBreakRec(input, result, set);
        //    WordBreakDP(input, result, set, memory);
        //    return result.ToList();
        //}

        //public static IList<string> WordBreakRec(string input, HashSet<string> result, HashSet<string> set)
        //{
        //    if (input.Length == 0)
        //    {
        //        return result.ToList();
        //    }

        //    for (var i = 1; i <= input.Length; i++)
        //    {
        //        var temp = input.Substring(0, i);
        //        if (set.Contains(temp))
        //        {
        //            result.Add(temp);
        //            WordBreakRec(input.Substring(i), result, set);
        //        }
        //    }
        //    return result.ToList();
        //}

        //public static IList<string> WordBreakDP(string input, HashSet<string> result, HashSet<string> set, IDictionary<string, bool> memory)
        //{
        //    if (input == "")
        //    {
        //        return result.ToList();
        //    }

        //    if
        //}

        public static bool WordBreak(string s, IList<string> wordDict)
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
    }
}
