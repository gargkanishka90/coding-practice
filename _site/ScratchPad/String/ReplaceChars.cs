using System.Collections.Generic;

namespace ScratchPad.String
{
    public class ReplaceChars
    {
        public static List<string> Replace(string word)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            var result = new List<string>();

            for (var i = 0; i < word.Length; i++)
            {
                foreach (var cg in letters)
                {
                    var newWord = word.Substring(0, i) + cg + word.Substring(i + 1);
                    if (newWord != word)
                    {
                        result.Add(newWord);
                    }
                }
            }
            return result;
        }
    }
}