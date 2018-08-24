using System;
using System.Collections.Generic;

namespace ScratchPad.Leetcode.Matrix
{
    public class SpiralMatrix
    {
        public int[] PrintSpiral(int[,] grid){
            var result = new List<int>();
            var M = grid.GetLength(0);
            var N = grid.GetLength(1);

            var left = 0;
            var right = N - 1;
            var up = 0;
            var down = M - 1;

            while(left <= right && up <= down){
                var left1 = left;
                var right1 = right;
                var up1 = up;
                var down1 = down;

                for (var i = left1; i <= right1; ++i){
                    result.Add(grid[up1, i]);
                }

                for (var j = up1 + 1; j <= down1; ++j){
                    result.Add(grid[j, right1]);
                }

                for (var i = right1 - 1; i >= left1; --i){
                    result.Add(grid[down1, i]);
                }

                for (var j = down1 - 1; j >= up1 + 1; --j){
                    result.Add(grid[j, left1]);
                }
                left++;
                right--;
                up++;
                down--;
            }
            return result.ToArray();
        }

        public int[,] FillMatrix(int n)
        {
            var grid = new int[n,n];
            var M = grid.GetLength(0);
            var N = grid.GetLength(1);

            var left = 0;
            var right = N - 1;
            var up = 0;
            var down = M - 1;
            var counter = 1;

            while (left <= right && up <= down)
            {
                var left1 = left;
                var right1 = right;
                var up1 = up;
                var down1 = down;

                for (var i = left1; i <= right1; ++i)
                {
                    grid[up1, i] = counter++;
                }

                for (var j = up1 + 1; j <= down1; ++j)
                {
                    grid[j, right1] = counter++;
                }

                for (var i = right1 - 1; i >= left1; --i)
                {
                    grid[down1, i] = counter++;
                }

                for (var j = down1 - 1; j >= up1 + 1; --j)
                {
                    grid[j, left1] = counter++;
                }
                left++;
                right--;
                up++;
                down--;
            }
            return grid;
        }
    }
}
