using System;

namespace ScratchPad.Arrays
{
    public class MatrixZeroTests
    {
        public static void Run()
        {
            var matrix = new int[][]
            {
                new int[]{1, 1, 0, 1, 0}, new int[]{1, 1, 1, 1, 1}, new int[]{1, 1, 1, 1, 1}
            };

            int[][] result = MatrixZero.SetZeros(matrix);

            var rowLength = result.Length;
            var colLength = result[0].Length;

            for (var row = 0; row < rowLength; row++)
            {
                for (var col = 0; col < colLength-1; col++)
                {
                    Console.Write(result[row][col] + " , ");
                }
                Console.Write(result[row][colLength-1]);
                Console.WriteLine();
            }
        } 
    }
}