using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Leetcode.Hard
{
    public class WordSearchII
    {
        IList<string> FindWords(char[,] board, string[] words)
        {
            return FindDictionaryWordsInTheGrid(words, board).ToList();
        }

        public IEnumerable<string> FindDictionaryWordsInTheGrid(IEnumerable<string> dictionary, char[,] grid)
        {
            var result = new List<string>();
            var trie = BuildTrie(dictionary);
            var gridMap = BuildGridMap(grid);
            var visited = new bool[grid.GetLength(0), grid.GetLength(1)];
            var N = grid.GetLength(0); // numRows
            var M = grid.GetLength(1); // numCols

            for (var row = 0; row < N; ++row){
                for (var col = 0; col < M; ++col){
                    if(ExistsInGrid(gridMap, grid[row, col])){
                        //visited[row, col] = true;
                        Compute(trie, grid, "" + grid[row, col], visited, row, col, result);
                        //visited[row, col] = false;
                    }
                }
            }

            return result;
        }

        private void Compute(Trie trie, char[,] grid, string partial, bool[,] visited, int x, int y, List<string> result)
        {
            if (trie.SearchWord(partial) && !result.Contains(partial))
            {
                result.Add(partial);
            }
            else
            {
                if(!visited[x, y])
                {
                    visited[x, y] = true;
                    var N = grid.GetLength(0); // numRows
                    var M = grid.GetLength(1); // numCols

                    // UP
                    if (x - 1 >= 0 && !visited[x - 1, y])
                        Compute(trie, grid, partial + grid[x - 1,y], visited, x - 1, y, result);

                    // DOWN
                    if (x + 1 < N && !visited[x + 1, y])
                        Compute(trie, grid, partial + grid[x + 1, y], visited, x + 1, y, result);

                    // LEFT
                    if (y - 1 >= 0 && !visited[x, y - 1])
                        Compute(trie, grid, partial + grid[x, y - 1], visited, x, y - 1, result);

                    // RIGHT
                    if (y + 1 < M && !visited[x, y + 1])
                        Compute(trie, grid, partial + grid[x, y + 1], visited, x, y + 1, result);

                    visited[x, y] = false;
                }
            }
        }

        private Dictionary<char, List<Point>> BuildGridMap(char[,] grid)
        {
            var table = new Dictionary<char, List<Point>>();
            var numRows = grid.GetLength(0);
            var numCols = grid.GetLength(1);
            for (var row = 0; row < numRows; ++row)
            {
                for (var col = 0; col < numCols; ++col)
                {
                    if (!table.ContainsKey(grid[row, col]))
                        table[grid[row, col]] = new List<Point>();
                    table[grid[row, col]].Add(new Point(row, col));
                }
            }
            return table;
        }

        private bool ExistsInGrid(Dictionary<char, List<Point>> grid, char key)
        {
            return grid.ContainsKey(key);   
        }
            
        public class Point{
            public int x;
            public int y;
            public bool visited = false;

            public Point(int xCoord, int yCoord){
                x = xCoord;
                y = yCoord;
            }

            public IEnumerable<Point> GetVerticalAndHorizontalNeighbors(){
                var result = new List<Point>();

                // UP
                if(x - 1 >= 0){
                    result.Add(new Point(x - 1, y));
                }

                // DOWN
                //if(x + 1 >= 0)

                return result;
            }
        }

        private Trie BuildTrie(IEnumerable<string> dictionary)
        {
            var trie = new WordSearchII.Trie();
            foreach(var word in dictionary){
                trie.InsertWord(word);
            }
            return trie;
        }

        public class Trie
        {
            public TrieNode _root;

            public Trie()
            {
                _root = new TrieNode(' ');
            }

            public void InsertWord(string word)
            {
                if (string.IsNullOrWhiteSpace(word))
                    return;

                var runner = _root;
                foreach (var ch in word)
                {
                    if (!runner.HasChild(ch))
                    {
                        runner.AddChild(ch);
                    }
                    runner = runner.GetChild(ch);
                }
                runner.SetEnd();
            }

            public bool SearchWord(string word)
            {
                if (string.IsNullOrWhiteSpace(word))
                    return false;

                var runner = _root;
                foreach (var ch in word)
                {
                    if (!runner.HasChild(ch))
                        return false;
                    runner = runner.GetChild(ch);
                }
                return runner?.IsEnd ?? false;
            }

            public bool StartsWith(string word)
            {
                if (string.IsNullOrWhiteSpace(word))
                    return false;

                var runner = _root;
                foreach (var ch in word)
                {
                    if (!runner.HasChild(ch))
                        return false;
                    runner = runner.GetChild(ch);
                }
                return runner != null;
            }
        }

        public class TrieNode
        {
            public char key;
            public TrieNode[] Children;
            public bool IsEnd;

            public TrieNode(char k)
            {
                key = k;
                Children = new TrieNode[26];
                IsEnd = false;
            }

            public bool HasChild(char toFind)
            {
                return Children[toFind - 'a'] != null;
            }

            public void AddChild(char toAdd)
            {
                if (Children[toAdd - 'a'] == null)
                {
                    Children[toAdd - 'a'] = new TrieNode(toAdd);
                }
            }

            public TrieNode GetChild(char toGet)
            {
                if (HasChild(toGet))
                    return Children[toGet - 'a'];
                return null;
            }

            public void SetEnd()
            {
                IsEnd = true;
            }
        }
    }


}
