using System;

namespace ScratchPad.Arrays
{
    public class MissingElement
    {
        public static int Find(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new Exception("one of the array is null");

            if( arr2.Length != arr1.Length -1) throw new Exception();

            var temp = arr1[0];
            for(var i = 1; i < arr1.Length; i++)
            {
                temp ^= arr1[i];
            }

            for (var i = 0; i < arr2.Length; i++)
            {
                temp ^= arr2[i];
            }
            return temp;
        } 
    }
}