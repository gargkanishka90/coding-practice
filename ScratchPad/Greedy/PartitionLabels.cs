using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Greedy
{
    public class PartitionLabels
    {
        public IList<int> Partition(string S)
        {
            var result = new List<int>();

            // "ababcbacadefegdehijhklij" -> [9,7,8]

            var endPositions = new Dictionary<char,int>();

            for (var pos = 0; pos < S.Length; pos++)
            {
                if (!endPositions.ContainsKey(S[pos]))
                {
                    endPositions[S[pos]] = -1;
                }
                endPositions[S[pos]] = pos;
            }

            var last = 0;
            var start = 0;
            for (var i = 0; i < S.Length; i++) 
            {
                last = Math.Max(last, endPositions[S[i]]);
                if (i == last)
                {
                    result.Add(last - start + 1);
                    start = last + 1;
                }
            }

            return result;
        }
    }
}
