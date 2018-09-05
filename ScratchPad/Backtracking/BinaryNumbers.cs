using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class BinaryNumbers
    {
        public IList<string> PrintAllBinaryOfSizeK(int k)
        {
            var result = new List<string>();
            BinaryNumberHelper(k, result, "");
            return result;
        }

        private void BinaryNumberHelper(int k, List<string> result, string partial)
        {
            if (partial.Length == k)
            {
                result.Add(partial);
            }
            else
            {
                BinaryNumberHelper(k, result, partial + "0");
                BinaryNumberHelper(k, result, partial + "1");
            }
        }

        public IList<string> PrintAllBinaryNumbersWithKBitsSet(int k, int N)
        {
            var result = new List<string>();
            BinaryNumbersWithKBitsSetHelper(N, k, result, "");
            return result;
        }

        private void BinaryNumbersWithKBitsSetHelper(int N, int k, List<string> result, string partial)
        {
            if (partial.Length == N)
            {
                if(partial.Count(p => p == '1') == k)
                {
                    result.Add(partial);
                }
            }
            else
            {
                BinaryNumbersWithKBitsSetHelper(N, k, result, partial + "0");
                BinaryNumbersWithKBitsSetHelper(N, k, result, partial + "1");
            }
        }
    }
}
