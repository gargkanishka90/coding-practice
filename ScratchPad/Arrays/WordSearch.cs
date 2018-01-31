using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Arrays
{
    public class WordSearch
    {
        public enum Direction
        {
            None = 0,
            Up = 1,
            Down = 2,
            Right = 3,
            Left = 4
        }

        public static bool Exist(char[,] board, string word)
        {
            var temp = new List<dynamic>();
            var found = 0;
            var rowLength = board.GetLength(0); //3
            var columnLength = board.GetLength(1); //4
            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < columnLength; j++)
                {
                    if (board[i, j] == word[0])
                    {
                        temp.Add($"{i}^{j}");
                        var r = WordSearchUtil(board, Direction.None, i, j, word, 1, rowLength, columnLength);
                        if (r)
                            return true;
                    }
                }
            }
            return false;
        }

        private static bool WordSearchUtil(char[,] board, Direction dir, int i, int j, string word, int index, int rowMax, int colMax)
        {
            //var found = 0;

            if (index == word.Length)
            {
                return true;
            }

            // Probe Down
            if (i + 1 < rowMax && dir != Direction.Down && board[i + 1, j] == word[index])
            {
                if (WordSearchUtil(board, Direction.Up, i + 1, j, word, index + 1, rowMax, colMax))
                    return true;
            }

            // Probe Up
            if (i - 1 >= 0 && dir != Direction.Up && board[i - 1, j] == word[index])
            {
                if (WordSearchUtil(board, Direction.Down, i - 1, j, word, index + 1, rowMax, colMax))
                    return true;
            }

            // Probe Left
            if (j - 1 >= 0 && dir != Direction.Left && board[i, j - 1] == word[index])
            {
                if (WordSearchUtil(board, Direction.Right, i, j - 1, word, index + 1, rowMax, colMax))
                    return true;
            }

            // Probe Right
            if (j + 1 < colMax && dir != Direction.Right && board[i, j + 1] == word[index])
            {
                if (WordSearchUtil(board, Direction.Left, i, j + 1, word, index + 1, rowMax, colMax))
                    return true;
            }

            return false;
        }
    }
}
