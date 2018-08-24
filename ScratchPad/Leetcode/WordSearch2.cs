using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class WordSearch2
    {

        public class TrieNode
        {
            public char Letter;
            public TrieNode[] Children;
            public bool IsWord;

            public TrieNode(char letter)
            {
                Letter = letter;
                Children = new TrieNode[26];
            }
        }

        public class Trie
        {

            public TrieNode _root;

            public Trie(string[] words)
            {
                _root = new TrieNode(' ');
                foreach (var word in words)
                {
                    AddWord(word);
                }
            }

            public void AddWord(string word)
            {
                var current = _root;
                foreach (var letter in word)
                {
                    var letterIndex = letter - 'a';
                    if (current.Children[letterIndex] == null)
                    {
                        current.Children[letterIndex] = new TrieNode(letter);
                    }
                    current = current.Children[letterIndex];
                }
                current.IsWord = true;
            }

            public bool Search(string word)
            {
                var current = _root;
                foreach (var letter in word)
                {
                    var letterIndex = letter - 'a';
                    if (current.Children[letterIndex] == null)
                    {
                        return false;
                    }
                    current = current.Children[letterIndex];
                }
                return current != null && current.IsWord;
            }

            public bool SearchPrefix(string word)
            {
                var current = _root;
                foreach (var letter in word)
                {
                    var letterIndex = letter - 'a';
                    if (current.Children[letterIndex] == null)
                    {
                        return false;
                    }
                    current = current.Children[letterIndex];
                }
                return true;
            }

            public List<char> GetPrefixChildren(string prefix)
            {
                var result = new List<char>();
                var current = _root;

                foreach (var letter in prefix)
                {
                    var letterIndex = letter - 'a';
                    if (current.Children[letterIndex] == null)
                    {
                        return null;
                    }
                    current = current.Children[letterIndex];
                }

                foreach (var child in current.Children)
                {
                    result.Add(child.Letter);
                }
                return result;
            }
        }

        public IList<string> FindWords(char[,] board, string[] words)
        {
            var found = new List<string>();
            if (board == null || board.GetLength(0) == 0 || board.GetLength(1) == 0)
                return found;

            // Build dictionary of words
            var dictionary = new Trie(words);
            var firstCharsOfDictWords = dictionary?._root?.Children?.Where(x => x != null).Select(q => q.Letter).ToList();



            var nRows = board.GetLength(0);
            var nCols = board.GetLength(1);

            var visited = new bool[nRows, nCols];

            for (var row = 0; row < nRows; row++)
            {
                for (var col = 0; col < nCols; col++)
                {
                    if (firstCharsOfDictWords.Contains(board[row, col]))
                    {
                        //visited[row,col] = true;
                        Searcher(row, col, "", board, dictionary, found, visited);
                    }
                }
            }
            return found;
        }

        private bool IsSafe(int row, int col, bool[,] visited, char[,] board)
        {
            return row >= 0 && col >= 0 && row < board.GetLength(0) && col < board.GetLength(1) && !visited[row, col];
        }

        private void Searcher(int row, int col, string prefix, char[,] board, Trie dict, List<string> found, bool[,] visited)
        {
            if (dict.Search(prefix))
            {
                found.Add(prefix);
            }

            if (IsSafe(row, col, visited, board))
            {
                visited[row, col] = true;

                if (IsSafe(row, col - 1, visited, board))
                    Searcher(row, col - 1, prefix + board[row, col - 1], board, dict, found, visited); // left

                if (IsSafe(row, col + 1, visited, board))
                    Searcher(row, col + 1, prefix + board[row, col + 1], board, dict, found, visited); // right

                if (IsSafe(row - 1, col, visited, board))
                    Searcher(row - 1, col, prefix + board[row - 1, col], board, dict, found, visited); // up

                if (IsSafe(row + 1, col, visited, board))
                    Searcher(row + 1, col, prefix + board[row + 1, col], board, dict, found, visited); // down

                visited[row, col] = false;
            }
            return;
        }
    }
}
