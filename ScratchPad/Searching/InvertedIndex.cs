using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ScratchPadTests.Searching
{
    public class InvertedIndex
    {
        private static readonly Dictionary<string, List<int>> _index = new Dictionary<string, List<int>>();
         
        public static void PreCompute(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                var currentword = words[i].ToLower();
                if (_index.ContainsKey(currentword))
                {
                    List<int> list;
                    _index.TryGetValue(currentword, out list);
                    if (list == null) continue;
                    list.Add(i+1);
                    _index[currentword] = list;
                }
                else
                {
                    _index[currentword] = new List<int>() {i+1};
                }
            }
        }

        public static void PrintDictionary()
        {
            foreach (var kv in _index)
            {
                Console.WriteLine("Key: " + kv.Key + " Values: " + GetValues(kv.Value));
            }
        }

        private static string GetValues(IEnumerable<int> values)
        {
            var result = new StringBuilder();
            foreach (var value in values)
            {
                result.Append(value + " ,");
            }
            return result.ToString();
        }
    }
}