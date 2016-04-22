using System;
using System.Linq;

namespace ScratchPad.String
{
    public static class UniqueCharacters
    {
        public static bool IsUnique(string word)
        {
            if (word.Length > 256)
            {
                return false;
            }

            var charSet = new bool[256];

            foreach (var c in word)
            {
                if (charSet[c - 'a']) return false;

                charSet[c - 'a'] = true;
            }
            return true;
        }

        public static bool IsUnique2(string word)
        {
            var checker = 0;
            foreach (var i in word.Select(c => c - 'a'))
            {
                if ((checker & (1 << i)) > 0)
                {
                    return false;
                }
                checker |= 1 << i;
            }
            return true;
        }
    }
}