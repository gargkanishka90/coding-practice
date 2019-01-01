using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.String
{
    public class RobinKarp
    {
        public int Search(string text, string pattern)
        {
            if (text.Length < pattern.Length)
                return -1;

            var tHash = 0;
            var pHash = 0;
            var BASE = 26;
            var power = 1;

            for (var i = 0; i < pattern.Length; i++)
            {
                power = i > 0 ? power * BASE : 1;
                pHash = pHash * BASE + pattern[i];
                tHash = tHash * BASE + text[i];
            }

            for (var i = pattern.Length; i + pattern.Length < text.Length; i++)
            {
                if (pHash == tHash && text.Substring(i - pattern.Length, pattern.Length) == pattern)
                {
                    return i - pattern.Length;
                }

                // calculate rolling hash
                tHash = -text[i - pattern.Length] * power;
                tHash = tHash * BASE + text[i];
            }

            if (pHash == tHash && text.Substring(text.Length - pattern.Length, pattern.Length) == pattern)
            {
                return text.Length - pattern.Length;
            }

            return -1;
        }
    }
}
