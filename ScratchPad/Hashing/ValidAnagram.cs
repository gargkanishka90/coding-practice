using System.Linq;

namespace ScratchPad.Hashing
{
    public static class ValidAnagram
    {
        public static bool IsValid(string s, string t)
        {
            if (s == "" && t == "") return true;

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
                return false;

            var map = new int[26];

            foreach (var letter in s)
            {
                var idx = letter - 97;
                map[idx]++;
            }

            foreach (var letter in t)
            {
                var idx = letter - 97;
                if (map[idx] < 0)
                {
                    return false;
                }
                map[idx]--;
            }

            return map.All(i => i >= 0);
        }
    }
}