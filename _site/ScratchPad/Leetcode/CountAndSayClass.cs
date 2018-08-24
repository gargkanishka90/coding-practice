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

        //"1", "11", "21", "1211", "111221", "312211" etc.......
        private string nextCount(string previous)
        {
            var sb = new StringBuilder();
            var count = 1;
            var current = previous[0];
            var i = 0;

            for (i = 1; i < previous.Length; i++)
            {
                if(previous[i] == current){
                    count++;
                } else {
                    sb.Append(count.ToString() + current.ToString());
                    count = 1;
                    current = previous[i];
                }
            }

            if (i == 1)
                return "11";
            else
            {
                sb.Append(count.ToString() + current.ToString());
            }
            
            return sb.ToString();
        }
    }
}
