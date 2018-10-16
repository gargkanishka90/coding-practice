using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode.Hard
{
    public class MinWindowSubstring
    {
        public string MinWindow(string source, string target)
        {
            if (source == null 
                || target == null 
                || target.Length > source.Length 
                || source.Length == 0 
                || target.Length == 0)
                return "";

            var characterMap = new Dictionary<char, int>();

            foreach (var letter in target)
            {
                if (!characterMap.ContainsKey(letter))
                {
                    characterMap[letter] = 1;
                }
                else
                {
                    characterMap[letter]++;
                }
            }

            var begin = 0;
            var end = 0;
            var minBegin = 0;
            var minLength = int.MaxValue;

            var lettersToMatch = characterMap.Keys.Count;

            while (end < source.Length)
            {
                var temp = source[end];
                if (characterMap.ContainsKey(temp))
                {
                    characterMap[temp]--;
                    if (characterMap[temp] == 0)
                    {
                        lettersToMatch--;
                    }
                }

                // distinctLetters is 0 means all the letters in target are in source substring
                // distinctLetters > 0 means not all letters in target are in source substring
                while (lettersToMatch == 0)
                {
                    if (end - begin < minLength)
                    {
                        minLength = end - begin + 1;
                        minBegin = begin;
                    }

                    // sliding starts from here.
                    if (characterMap.ContainsKey(source[begin]))
                    {
                        characterMap[source[begin]]++;
                        if (characterMap[source[begin]] > 0)
                        {
                            lettersToMatch++;
                        }
                    }

                    begin++;
                }

                end++;
            }

            if (minLength <= source.Length)
                return source.Substring(minBegin, minLength);

            return "";
        }
    }
}
