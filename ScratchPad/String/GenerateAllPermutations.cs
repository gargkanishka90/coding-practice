using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ScratchPad.String
{
    public class GenerateAllPermutations
    {
        public static List<string> GetPermutations(string thisString)
        {
            var myResult = new List<string>();
            if (thisString.Length == 0)
            {
                myResult.Add("");
                return myResult;
            }

                var first = thisString[0];
                var subresults = GetPermutations(thisString.Substring(1));
                foreach (var subresult in subresults)
                {
                    for (var j = 0; j <= subresult.Length; ++j)
                    {
                        myResult.Add(subresult.Substring(0,j) + first + subresult.Substring(j));
                    }
                }
            return myResult;
        }
    }
}