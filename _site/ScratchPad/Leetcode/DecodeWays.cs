using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class DecodeWays
    {
        // Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).
        public static int NumDecodings(string s)
        {
            var alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (s == null || s.Length == 1) return 1;

            return 0;
        }
    }
}
