using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.Hashing
{
    public class FrequencySort
    {

        public static string Sort(string s)
        {
            StringBuilder sortedString = new StringBuilder();

            var freqMap = new Dictionary<char,int>();

            foreach (var ch in s)
            {
                if (freqMap.ContainsKey(ch))
                {
                    freqMap[ch] += 1;
                }
                else
                {
                    freqMap[ch] = 1;
                }
            }

            foreach (var pair in freqMap.OrderBy(kv => -kv.Value))
            {
                for (var i = 1; i <= pair.Value; i++)
                {
                    sortedString.Append(pair.Key);
                }
            }

            return sortedString.ToString();
        }
    }
}