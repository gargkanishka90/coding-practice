using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Hashing
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> Group(string[] dictionary)
        {
            var map = new Dictionary<string, IList<string>>();

            foreach (var word in dictionary)
            {
                var arrayWord = word.ToCharArray();
                Array.Sort<char>(arrayWord);
                var sortedWord = new string(arrayWord);

                if (!map.Keys.Contains(sortedWord))
                {
                    map[sortedWord] = new List<string>();
                }

                map[sortedWord].Add(word);
            }

            return map.Select(kv => kv.Value).ToList();
        }
    }
}