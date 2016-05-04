namespace ScratchPad.Arrays
{
    public class MatrixZero
    {
        public static int[][] SetZeros(int[][] matrix)
        {
            var rowLength = matrix.Length;
            var colLength = matrix[0].Length;
            var rows = new bool[rowLength];
            var columns = new bool[colLength];

            for (var row = 0; row < rowLength; row++)
            {
                for (var col = 0; col < colLength; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        rows[row] = true;
                        columns[col] = true;
                    }
                }
            }

            for (var row = 0; row < rowLength; row++)
            {
                for (var col = 0; col < colLength; col++)
                {
                    if (rows[row])
                    {
                        // make all the elements in this row as zero
                        for (var i = 0; i < colLength; i++)
                        {
                            matrix[row][i] = 0;
                        }
                    }

                    if (columns[col])
                    {
                        // make all the elements in this row as zero
                        for (var i = 0; i < rowLength; i++)
                        {
                            matrix[i][col] = 0;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}