using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class ArrayRotation
    {
        public static void Rotate(int[] nums, int k)
        {
            var temp = new int[k];

            // save last k elements in temp
            for (int i = nums.Length - k, j = 0; i < nums.Length; i++, j++)
            {
                temp[j] = nums[i];
            }

            // shift elements to the right by k
            for (var i = nums.Length-k-1; i >= 0; i--)
            {
                nums[i + k] = nums[i];
            }

            for (var i = 0; i <= k - 1; i++)
            {
                nums[i] = temp[i];
            }
        }

        public static void Rotate(int[,] matrix)
        {
            var numRows = matrix.GetLength(0); // Num of rows
            var numColumns = matrix.GetLength(1); // Num of columns

            for (var layer = 0; layer < numColumns / 2; layer++)
            {
                var first = layer;
                var last = numColumns - layer - 1;

                for (var i = first; i < last; i++)
                {
                    var offset = i - first;
                    var temp = matrix[first, i];

                    // move left to top
                    matrix[first, i] = matrix[last-i+first, first];

                    // move bottom to left
                    matrix[last-i+first, first] = matrix[last, last-i+first];

                    // move right to bottom
                    matrix[last, last - i + first] = matrix[i, last];

                    // temp -> right
                    matrix[i, last] = temp;
                }
            }
        }

        public static int[,] ImageSmoother(int[,] matrix)
        {
            var x = matrix.GetLength(0);
            var y = matrix.GetLength(1);
            var res = new int[x, y];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    var total = matrix[row, col];
                    var count = 1;
                    if (col > 0 && row > 0)
                    {
                        
                    }
                }
            }

            return res;
        }
    }
}
