using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.String
{
    public class FindFirstUniqueCharacter
    {
        public static char Find(string input)
        {
            if(input == null) throw new Exception();

            if (input.Length == 1) return input[0];

            var table = new Dictionary<char, bool>();

            foreach (var ch in input)
            {
                if (!table.ContainsKey(ch))
                {
                    table[ch] = false;
                }
                else
                {
                    table[ch] = true;
                }
            }

            foreach (var kv in table.Where(kv => !kv.Value))
            {
                return kv.Key;
            }
            return ' ';
        }
    }
}