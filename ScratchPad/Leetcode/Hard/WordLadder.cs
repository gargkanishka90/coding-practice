using System;
using System.Collections.Generic;

namespace ScratchPad.Leetcode.Hard
{
    public class WordLadder
    {
        public int LadderLength(string word1, string word2, IList<string> dict)
        {

            var wordSet = new HashSet<string>(dict);
            var queue = new Queue<Node>();
            queue.Enqueue(new Node(word1, 1));
            var visited = new HashSet<string>();


            while (queue.Count > 0)
            {
                var top = queue.Dequeue();
                if (top.word == word2)
                    return top.distance;

                var entry = top.word.ToCharArray();

                for (var i = 0; i < entry.Length; i++)
                {
                    for (var ch = 'a'; ch <= 'z'; ch++)
                    {
                        var temp = entry[i];

                        if (entry[i] != ch)
                            entry[i] = ch;

                        var newWord = new string(entry);

                        if (wordSet.Contains(newWord))
                        {
                            queue.Enqueue(new Node(newWord, top.distance + 1));
                            wordSet.Remove(newWord);
                        }

                        entry[i] = temp;
                    }
                }
            }

            return 0;
        }

        public class Node
        {
            public string word { get; set; }
            public int distance { get; set; }

            public Node(string word, int distance)
            {
                this.word = word;
                this.distance = distance;
            }
        }
    }
}
