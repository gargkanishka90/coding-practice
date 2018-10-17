using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode.Hard
{
    public class AutocompleteSystem
    {
        StringBuilder query;
        private AutocompleteTrie _trie;
        // Users may input a sentence (at least one word and end with a special character '#')
        // For each character they type except '#', you need to return the top 3 historical hot sentences that have prefix the same as the part of sentence already typed.

        //Here are the specific rules:

        //1. The hot degree for a sentence is defined as the number of times a user typed the exactly same sentence before.
        //2. The returned top 3 hot sentences should be sorted by hot degree (The first is the hottest one). If several sentences have the same degree of hot, you need to use ASCII-code order(smaller one appears first).
        //3. If less than 3 hot sentences exist, then just return as many as you can.
        //4. When the input is a special character, it means the sentence ends, and in this case, you need to return an empty list.
        public AutocompleteSystem(string[] historicalSentences, int[] times)
        {
            _trie = new AutocompleteTrie();
            if(query == null)
                query = new StringBuilder();
            for (var i = 0; i < historicalSentences.Length; i++)
            {
                _trie.AddWord(historicalSentences[i], times[i]);
            }
        }

        public IList<string> Input(char c)
        {
            IList<TrieQueryNode> res;
            if (c != '#')
            {
                query.Append(c);
                res = _trie.GetWordsWithThisPrefix(query.ToString());
            } 
            else 
            {
                // end of sentence so update the record in trie.
                _trie.AddWord(query.ToString());
                query.Clear();
                res = new List<TrieQueryNode>();
            }
            return Filter(res);
        }

        private IList<string> Filter(IList<TrieQueryNode> result)
        {
            var res = new List<string>();
            if (result == null || result.Count == 0)
                return res;

            var sortedByCount = result.OrderByDescending(s => s.times).ToList();
            if (sortedByCount == null)
                return res;

            foreach (var item in sortedByCount)
            {
                res.Add(item.sentence);
                if (res.Count == 3)
                    break;
            }
            return res;
        }
    }

    public class AutocompleteTrie
    {
        private TrieNode _root;

        public AutocompleteTrie()
        {
            _root = new TrieNode(' ');
        }

        public void AddWord(string input, int times = 0)
        {
            var runner = _root;
            foreach (var ch in input)
            {
                if (!runner.Children.ContainsKey(ch))
                    runner.Children[ch] = new TrieNode(ch);

                runner = runner.Children[ch];
            }

            if(times > 0)
                runner.count = times;
            else
            {
                runner.count++;
            }

            runner.IsEnd = true;
        }

        public IList<TrieQueryNode> GetWordsWithThisPrefix(string prefix)
        {
            var runner = _root;
            var result = new List<TrieQueryNode>();
            foreach (var ch in prefix)
            {
                if (!runner.Children.ContainsKey(ch))
                    return null;

                runner = runner.Children[ch];
            }

            FindPrefixSentences(runner, result, prefix);
            return result;
        }

        private void FindPrefixSentences(TrieNode runner, List<TrieQueryNode> result, string prefix)
        {
            if (runner.IsEnd)
            {
                result.Add(new TrieQueryNode()
                {
                    sentence = prefix,
                    times = runner.count
                });

                if (runner.Children.Count > 0)
                {
                    foreach (var child in runner.Children)
                    {
                        FindPrefixSentences(child.Value, result, prefix + child.Key);
                    }
                }
            }
            else
            {
                foreach (var child in runner.Children)
                {
                    FindPrefixSentences(child.Value, result, prefix + child.Key);
                }
            }
        }
    }

    public class TrieQueryNode
    {
        public string sentence { get; set; }
        public int times { get; set; }
    }

    internal class TrieNode
    {
        public char key { get; }
        public int count { get; set; }
        public bool IsEnd { get; set; }

        public IDictionary<char, TrieNode> Children{ get; set; }

        internal TrieNode(char ch, int times = 0)
        {
            key = ch;
            count = times;
            Children = new Dictionary<char,TrieNode>(); // a-z,A-Z,#,' '
        }
    }
}