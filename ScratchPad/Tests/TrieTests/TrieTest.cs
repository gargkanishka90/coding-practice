using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class TrieTest
    {
        public static void Run()
        {
            var trie = new Trie();
            string[] words = { "ken", "kani", "kanishka", "ken", "crazy", "ken" };
            for (int i = 0; i < words.Length; i++)
            {
                trie.AddWord(words[i], i + 1);
            }
            Console.WriteLine(trie.HasWord("kanishka"));
            Console.WriteLine(trie.HasWord("kanishk"));
            //Console.WriteLine(trie.WordCount("ken"));
            var positions = trie.WordPositions("ken");
            foreach (var a in positions)
            {
                Console.WriteLine(a);
            }
        }
    }
}