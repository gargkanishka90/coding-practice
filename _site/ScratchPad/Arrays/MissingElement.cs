using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

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

        public static int Find2(int[] arr1, int[] arr2)
        {
            var table = new Dictionary<int, int>();

            foreach (var item in arr1)
            {
                if (!table.ContainsKey(item))
                {
                    table[item] = 1;
                }
                else
                {
                    table[item] = table[item] + 1;
                }
            }

            foreach(var item in arr2)
            {
                if (!table.ContainsKey(item))
                {
                    throw new Exception();
                }
                else
                {
                    table[item] = table[item] - 1;
                }
            }

            foreach (var x in table.Keys.Where(x => table[x] == 1))
            {
                return x;
            }
            throw new Exception();
        }
    }
}