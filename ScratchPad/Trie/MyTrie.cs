using System;
using System.Collections.Generic;

namespace ScratchPad.Trie
{
    public class MyTrie : ITrie
    {
        TrieNode _root;

        public MyTrie()
        {
            _root = new TrieNode(' ', new Dictionary<char, TrieNode>(), 0);
        }

        public void AddWord(string word, int pos)
        {
            if (string.IsNullOrWhiteSpace(word))
                return;

            var runner = _root;
            foreach(var ch in word){
                if(!runner.Children.ContainsKey(ch)){
                    runner.Children.Add(ch, new TrieNode(ch, new Dictionary<char, TrieNode>(), 0));
                } 
                runner = runner.Children[ch];
            }
            runner.Positions.Add(pos);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ICollection<string> GetWords()
        {
            throw new NotImplementedException();
        }

        public ICollection<string> GetWords(string prefix)
        {
            throw new NotImplementedException();
        }

        public bool HasWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;

            var runner = _root;
            foreach(var ch in word){
                if(runner.Children.ContainsKey(ch)){
                    runner = runner.Children[ch];
                } else {
                    return false;
                }
            }
            return true;
        }

        public void RemoveWord(string word)
        {
            throw new NotImplementedException();
        }

        public int WordCount(string word)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> WordPositions(string word)
        {
            throw new NotImplementedException();
        }
    }
}
