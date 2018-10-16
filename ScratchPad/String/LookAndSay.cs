using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticePad.Leetcode;

namespace ScratchPad.String
{
    //1 
    //11
    //21
    //1211
    //111221
    //312211
    //13112221
    public class LookAndSay
    {
        public IList<string> Generate(int n)
        {
            var result = new List<string>();
            var seed = "1";
            result.Add(seed);
            n--;

            StringBuilder sb;
            while (n > 0)
            {
                sb = new StringBuilder();
                var first = seed[0];
                var count = 1;
                for(var i = 1; i < seed.Length; i++)
                {
                    if (seed[i] == first)
                    {
                        count++;
                    }
                    else
                    {
                        sb.Append(count.ToString());
                        sb.Append(seed[i - 1]);
                        first = seed[i];
                        count = 1;
                    }
                }

                sb.Append(count.ToString());
                sb.Append(seed[seed.Length - 1]);
                result.Add(sb.ToString());
                seed = sb.ToString();
                n--;
            }

            return result;
        }

        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            var nSequences = Generate(n);
            return nSequences.Last();
        }
    }
}
