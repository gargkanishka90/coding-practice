using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScratchPad.String
{
    public class StringEdit
    {
        //An edit is:
        //1. Inserting one character anywhere in the word(including at the beginning and end)
        //2. Removing one character
        //3. Replacing one character
        public bool OneEditApart(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                return false;

            if (s1 == s2)
                return true;

            StringBuilder sb;
            var options = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // insert a character
            foreach (var ch in options)
            {
                sb = new StringBuilder();
                for (var i = 0; i <= s1.Length; i++)
                {
                    var part1 = s1.Substring(0, i);
                    var part2 = s1.Substring(i);
                    sb.Append(part1);
                    sb.Append(ch);
                    sb.Append(part2);

                    if (sb.ToString() == s2)
                        return true;

                    sb.Clear();
                }
            }

            // remove a character
            sb = new StringBuilder();
            for (var i = 0; i < s1.Length; i++)
            {
                var part1 = s1.Substring(0, i);
                var part2 = s1.Substring(i+1);
                sb.Append(part1);
                sb.Append(part2);

                if (sb.ToString() == s2)
                    return true;

                sb.Clear();
            }

            // replace a character.
            foreach (var ch in options)
            {
                sb = new StringBuilder();
                for (var i = 0; i < s1.Length; i++)
                {
                    var part1 = s1.Substring(0, i);
                    var part2 = s1.Substring(i+1);
                    sb.Append(part1);
                    sb.Append(ch);
                    sb.Append(part2);

                    if (sb.ToString() == s2)
                        return true;

                    sb.Clear();
                }
            }

            return false;
        }

        public bool OneEditApartEfficient(string s1, string s2)
        {
            // This check to cover the case where s1 = "" and s2 = ""
            if (string.IsNullOrWhiteSpace(s1) && string.IsNullOrWhiteSpace(s2))
                return false;

            // This check to cover the case where s1 = "c" and s2 = "c"
            if (s1 == s2)
                return false;

            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;

            for (var i = 0; i < Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] != s2[i])
                {
                    if (s1.Length == s2.Length)
                    {
                        return s1.Substring(i + 1) == s2.Substring(i + 1);
                    }

                    if (s1.Length < s2.Length)
                    {
                        return s1.Substring(i) == s2.Substring(i + 1);
                    }
                    else
                    {
                        return s1.Substring(i + 1) == s2.Substring(i);
                    }
                }
            }

            return (Math.Abs(s1.Length - s2.Length)) == 1;
        }
    }
}
