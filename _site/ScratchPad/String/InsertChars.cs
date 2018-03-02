using System.Collections.Generic;

namespace ScratchPad.String
{
    public class InsertChars
    {
        public static List<string> Insert(string word)
        {
            var result = new List<string>();
            string letters = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i <= word.Length; i++)
            {
                foreach (var ch in letters)
                {
                    var newWord = word.Substring(0, i) + ch + word.Substring(i);
                    result.Add(newWord);
                }
            }
            return result;
        }
    }
}