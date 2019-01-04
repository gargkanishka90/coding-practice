using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DynamicProgramming
{
    public class ScoreCombinations
    {
        public int FindNumberOfCombinations(int total, int[] individualPlays)
        {
            var dp = new int[individualPlays.Length, total + 1];

            for (var r = 0; r < individualPlays.Length; r++)
            {
                dp[r, 0] = 1;
                for (var c = 1; c <= total; c++)
                {
                    var withoutThisPlay = r-1 >= 0 ? dp[r - 1, c] : 0;
                    var withThisPlay = c >= individualPlays[r] ? dp[r, c - individualPlays[r]] : 0;
                    dp[r, c] = withThisPlay + withoutThisPlay;
                }
            }

            return dp[individualPlays.Length - 1, total];
        }
    }
}
