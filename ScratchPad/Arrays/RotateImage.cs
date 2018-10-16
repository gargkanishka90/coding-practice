using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Arrays
{
    public class RotateImage
    {
        //var image = new[,]
        //{
        //    {1, 2, 3},
        //    {4, 5, 6},
        //    {7, 8, 9}
        //};
        //var rotated = new int[,]
        //{
        //    { 7, 4, 1},
        //    { 8, 5, 2 },
        //    { 9, 6, 3 }
        //};
        public int[,] Rotate(int[,] image)
        {
            var numRows = image.GetLength(0);
            var numCols = image.GetLength(1);
            var layer = 0;

            while (2 * layer < numRows)
            {
                for (var k = layer; k < numCols - layer; k++)
                { 
                    // Save top-left
                    var temp = image[layer, k];

                    // bottom-left to top-left
                    image[layer, k] = image[numRows - 1 - k - layer, k - layer];

                    // bottom-right to bottom-left
                    image[numRows - 1 - k - layer, k - layer] = image[numRows - 1 -k -layer, numCols - 1 -k - layer];

                    // top-right to bottom-right
                    image[numRows - 1 - k - layer, numCols - 1 - k - layer] = image[k, numCols - 1 - k - layer];

                    // top-left to top-right
                    image[k, numCols - 1 - k - layer] = temp;
                }

                layer++;
            }

            return image;
        }
    }
}
