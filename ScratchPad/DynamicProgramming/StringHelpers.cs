using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DynamicProgramming
{
    public static class StringHelpers
    {
        public static IEnumerable<string> AllSubSequences(this string str)
        {
            var result = new List<string>();

            for (var startIndex = 0; startIndex < str.Length; startIndex++)
            {
                for (var len = 1; startIndex + len <= str.Length; len++)
                {
                    result.Add(str.Substring(startIndex, len));
                }
            }

            return result;
        }
    }
}
