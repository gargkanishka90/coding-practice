using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.HashTables
{
    public class PalindromicString
    {
        public static bool Check(string word)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach(var c in word)
            {
                if (!map.Keys.Contains(c))
                {
                    map[c] = 1;
                }
                else
                {
                    map[c] = map[c] + 1;
                }
            }

            int oddCount = 0;
            foreach(var kv in map)
            {
                if (kv.Value % 2 != 0)
                    oddCount++;
                if (oddCount > 1) return false;
            }
            return true;
        }
    }
}
