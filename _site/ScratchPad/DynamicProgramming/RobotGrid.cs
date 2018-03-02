using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Permissions;

namespace ScratchPad.DynamicProgramming
{
    public class RobotGrid
    {
        public static IList<Point> GetPath(int[,] maze)
        {
            if (maze == null || maze.Length == 0)
                return null;

            var path = new List<Point>();

            var cache = new Dictionary<Point, bool>();

            if(GetPath(maze, maze.GetLength(0) - 1, maze.GetLength(1) -1, path, cache))
                return path;

            return null;
        }

        private static bool GetPath(int[,] maze, int row, int col, List<Point> path, IDictionary<Point, bool> cache)
        {
            if (row < 0 || col < 0 || maze[row, col] == 0) return false;

            var point = new Point(row, col);

            if (cache.ContainsKey(point))
            {
                return cache[point];
            }

            var success = false;
            var isOrigin = (row == 0) && (col == 0);

            if (isOrigin || GetPath(maze, row - 1, col, path, cache) ||
                GetPath(maze, row, col - 1, path, cache))
            {
                path.Add(point);
                success = true;
            }

            cache[point] = success;
            return success;
        }
    }

    public class Point
    {
        private int X { get; }
        private int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}