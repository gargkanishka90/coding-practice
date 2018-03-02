using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class Path
    {
        public int x;
        public int y;

        public Path(int i, int j)
        {
            x = i;
            y = j;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Path;
            return this.x == other?.x && this.y == other?.y;
        }
    }
    
    public class RobotPath
    {
        public static IList<Path> GetPath(int[,] grid)
        {
            var numRows = grid.GetLength(0);
            var numCols = grid.GetLength(1);
            var memory = new Dictionary<Path, bool>();
            var result = new List<Path>();
            if(PathUtil(grid, 0, 0, numRows-1, numCols-1, memory, result))
                return result;
            return null;
        }

        private static bool PathUtil(int[,] grid, int row, int col, int rowMax, int colMax, IDictionary<Path, bool> memory, IList<Path> path)
        {
            if (row > rowMax || col > colMax || (grid[row,col] == 0))
                return false;

            var pth = new Path(row, col);
            if (memory.ContainsKey(pth))
            {
                return memory[pth];
            }
            
            var success = false;
            var IsAtLast = (row == rowMax) && (col == colMax);

            if (IsAtLast
                 || PathUtil(grid, row + 1, col, rowMax, colMax, memory, path)
                || PathUtil(grid, row, col + 1, rowMax, colMax, memory, path))
            {
                path.Insert(0,pth);
                success = true;
            }

            memory[pth] = success;
            
            return success;
        }
    }
}
