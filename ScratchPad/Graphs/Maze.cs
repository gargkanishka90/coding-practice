using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Graphs
{
    public class Maze
    {
        public class Point : IComparable<Point>
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int CompareTo(Point o)
            {
                if (this == o)
                {
                    return 0;
                }

                if (o == null)
                {
                    return -1;
                }

                var that = (Point) o;

                if (X != that.X || Y != that.Y)
                {
                    return -1;
                }

                return 0;
            }
        }

        public string FindShortestWay(int[,] maze, int[] ball, int[] hole)
        {
            var defaultResult = "impossible";
            if (maze == null || maze.GetLength(0) == 0)
                return defaultResult;

            var start = new Point(ball[0], ball[1]);
            var end = new Point(hole[0], hole[1]);

            var candidates = new SortedSet<string>();

            var queue = new Queue<Tuple<Point,string>>();
            queue.Enqueue(Tuple.Create(start, ""));

            while (queue.Count > 0)
            {
                var head = queue.Dequeue();
                if (head.Item1.X == end.X && head.Item1.Y == end.Y)
                {
                    if (candidates.Count > 0 && candidates.Last().Length < head.Item2.Length)
                        break;

                    candidates.Add(head.Item2);
                }
                else
                {
                    var neighbors = FindFeasibleNextMoves(head.Item1, maze);
                    foreach (var node in neighbors)
                    {
                        var direction = FindDirection(node, head.Item1);
                        queue.Enqueue(Tuple.Create(node, head.Item2 + direction));
                    }
                }
            }

            if (candidates.Count == 0)
                return defaultResult;

            return BuildPath(candidates.First());
        }

        private string BuildPath(string first)
        {
            var sb = new StringBuilder();
            sb.Append(first[0]);

            for (var i = 1; i < first.Length; i++)
            {
                if (first[i] == first[i-1])
                {
                    continue;
                }

                sb.Append(first[i]);
            }

            return sb.ToString();
        }

        private char FindDirection(Point current, Point next)
        {
            if (current.X + 1 == next.X)
                return 'u';

            if (current.X - 1 == next.X)
                return 'd';

            if (current.Y + 1 == next.Y)
                return 'l';

            return 'r';
        }

        private IList<Point> FindFeasibleNextMoves(Point current, int[,] maze)
        {
            var nextMoves = new List<Point>();
            var nR = maze.GetLength(0);
            var nC = maze.GetLength(1);

            if (current.X + 1 < nR && maze[current.X + 1, current.Y] == 0)
            {
                // Down
                nextMoves.Add(new Point(current.X + 1, current.Y));
            }

            if (current.X - 1 >= 0 && maze[current.X - 1, current.Y] == 0)
            {
                // Up
                nextMoves.Add(new Point(current.X - 1, current.Y));
            }

            if (current.Y + 1 < nC && maze[current.X, current.Y + 1] == 0)
            {
                // Right
                nextMoves.Add(new Point(current.X, current.Y + 1));
            }

            if (current.Y - 1 >= 0 && maze[current.X, current.Y - 1] == 0)
            {
                // Left
                nextMoves.Add(new Point(current.X, current.Y - 1));
            }

            return nextMoves;
        }

        public IList<Point> FindStartToEndPath(int[,] maze, int[] start, int[] end)
        {
            var path = new List<Point>();
            var source = new Point(start[0], start[1]);
            var destination = new Point(end[0], end[1]);

            path.Add(source);
            maze[source.X, source.Y] = 1;
            if (!SearchHelper(maze, source, destination, path))
            {
                path.RemoveAt(path.Count - 1);
            }

            return path;
        }

        private bool SearchHelper(int[,] maze, Point source, Point destination, IList<Point> path)
        {
            if (source.X == destination.X && source.Y == destination.Y)
                return true;

            var neighbors = FindFeasibleNextPoints(source, maze);

            foreach (var next in neighbors.Reverse())
            {
                path.Add(next);
                maze[next.X, next.Y] = 1;
                if (SearchHelper(maze, next, destination, path))
                {
                    return true;
                }
                path.RemoveAt(path.Count-1);
            }

            return false;
        }

        private IList<Point> FindFeasibleNextPoints(Point current, int[,] maze)
        {
            var nextMoves = new List<Point>();
            var nR = maze.GetLength(0);
            var nC = maze.GetLength(1);

            if (current.X + 1 < nR && maze[current.X + 1, current.Y] == 0)
            {
                // Down
                nextMoves.Add(new Point(current.X + 1, current.Y));
            }

            if (current.X - 1 >= 0 && maze[current.X - 1, current.Y] == 0)
            {
                // Up
                nextMoves.Add(new Point(current.X - 1, current.Y));
            }

            if (current.Y + 1 < nC && maze[current.X, current.Y + 1] == 0)
            {
                // Right
                nextMoves.Add(new Point(current.X, current.Y + 1));
            }

            if (current.Y - 1 >= 0 && maze[current.X, current.Y - 1] == 0)
            {
                // Left
                nextMoves.Add(new Point(current.X, current.Y - 1));
            }

            return nextMoves;
        }
    }
}
