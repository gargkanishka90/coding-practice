using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ScratchPad.String
{
    public class GenerateAllPermutations
    {
        public static List<string> permutations(string thisString)
        {
            List<string> myResult = new List<string>();
            if (thisString.Length <= 1)
            {
                myResult.Add(thisString);
            }
            else
            {
                for (int i = 0; i < thisString.Length; i++)
                {
                    myResult.AddRange(
                          permutations(thisString.Substring(0, i) + thisString.Substring(i + 1))
                                    .Select(x => thisString.Substring(i, 1) + x));
                }
            }
            return myResult;
        }
    }
}