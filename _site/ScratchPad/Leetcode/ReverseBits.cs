using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class ReverseBitsClass
    {
        public int Reverse(int x)
        {
            var negative = x < 0;

            var numDigits = 0;
            var copy = x;

            while (copy > 0)
            {
                copy /= 10;
                numDigits++;
            }

            var rev = 0;

            while (x > 9)
            {
                var mult = (numDigits - 1);
                rev += ((int)Math.Pow(10, mult)) * (x % 10);
                x = x / 10;
                numDigits--;
            }

            rev += x;

            return negative  ? -1 * rev : rev;
        }
    }
}
