//using System;
//using System.Collections.Generic;

//namespace ScratchPad
//{
//    public class Trie : ITrie
//    {
//        private TrieNode root;

//        public Trie()
//        {
//            root = new TrieNode(' ', new Dictionary<char, TrieNode>(), 0);
//        }

//        public void AddWord(string word, int pos)
//        {
//            AddWord(root, word.ToCharArray(), pos);
//        }

//        private void AddWord(TrieNode root, char[] word, int pos)
//        {
//            TrieNode current = root;
//            foreach (var c in word)
//            {
//                var next = current.GetChild(c);
//                if (next == null)
//                {
//                    next = new TrieNode(c, new Dictionary<char, TrieNode>(), 0);
//                    current.SetChild(next);
//                }
//                current = next;
//            }
//            current.WordCount++;
//            current.Positions.Add(pos);
//        }

//        public void RemoveWord(string word)
//        {
//            throw new System.NotImplementedException();
//        }

//        public ICollection<string> GetWords()
//        {
//            throw new System.NotImplementedException();
//        }

//        public ICollection<string> GetWords(string prefix)
//        {
//            throw new System.NotImplementedException();
//        }

//        public bool HasWord(string word)
//        {
//            var node = GetTrieNode(word);

//            return node != null && node.IsWord;
//        }

//        private TrieNode GetTrieNode(string word)
//        {
//            var next = root;
//            foreach (var c in word)
//            {
//                next = next.GetChild(c);
//                if (next == null)
//                {
//                    break;
//                }
//            }
//            return next;
//        }

//        public int WordCount(string word)
//        {
//            var node = GetTrieNode(word);

//            return (node == null ? 0 : node.WordCount);
//        }

//        public IEnumerable<int> WordPositions(string word)
//        {
//            var node = GetTrieNode(word);

//            return node.Positions;
//        }

//        public void Clear()
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}