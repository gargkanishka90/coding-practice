using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Arrays
{
    public class SquareSum
    {
        public bool JudgeSquareSum(int c)
        {
            for (var a = 1; a * a < c; a++)
            {
                var b = c - a * a;
                if (binary_search(0, b, b))
                    return true;
            }

            return false;
        }

        public bool binary_search(long s, long e, int n)
        {
            if (s > e)
                return false;
            long mid = s + (e - s) / 2;
            if (mid * mid == n)
                return true;
            if (mid * mid > n)
                return binary_search(s, mid - 1, n);
            return binary_search(mid + 1, e, n);
        }
    }
}
