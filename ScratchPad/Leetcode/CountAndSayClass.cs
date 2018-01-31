using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class CountAndSayClass
    {
        public string CountAndSay(int n)
        {
            var start = "1";
            if (n == 1) return start;
            var res = new string[n];
            res[0] = "1";

            for (var i = 1; i < n; i++)
            {
                res[i] = nextCount(res[i - 1]);
            }
            return res[n - 1];
        }

        //"21"
        private string nextCount(string previous)
        {
            var sb = new StringBuilder();
            var count = 1;
            var value1 = ' ';
            var i = 0;

            if (previous.Length == 1)
            {
                return "1" + previous[0];
            }

            for (i = 1; i < previous.Length; i++)
            {
                value1 = previous[i-1];

                if (previous[i] == value1)
                {
                    count++;
                    continue;
                }
                else
                {
                    sb.Append(count).Append(value1 - '0');
                    count = 1;
                }  
            }
            return sb.ToString();
        }
    }
}
