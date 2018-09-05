using System;
using System.Collections.Generic;

namespace ScratchPad.Backtracking
{
    public class PalindromePartition
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            if (string.IsNullOrWhiteSpace(s))
            {
                result.Add(new List<string>());
                return result;
            }

            Helper(s, 0, result, new List<string>());
            return result;
        }

        private void Helper(string s, int start, List<IList<string>> result, List<string> partial)
        {
            if (start == s.Length)
            {
                Console.WriteLine($"start: {start}, RESULT: [ {string.Join(" , ", partial.ToArray())} ]");
                result.Add(new List<string>(partial));
            }
            else
            {
                for (var i = start; i < s.Length; ++i)
                {
                    var temp = s.Substring(start, i - start + 1);
                    var isPalindrome = IsPalindrome(temp);
                    Console.WriteLine($"Is '{temp}' a palindrome? {(isPalindrome ? "YES" : "NO")}");
                    if (isPalindrome)
                    {
                        partial.Add(temp);
                        Console.WriteLine($"ADD - start: {start}, temp: {temp}, partial: [ {string.Join(" , ", partial.ToArray())} ]");
                        Helper(s, i + 1, result, partial);
                        partial.RemoveAt(partial.Count - 1);
                        Console.WriteLine($"REMOVE/BACKTRACK - start: {start}, temp: {temp}, partial: [ {string.Join(" , ", partial.ToArray())} ]");
                    }
                }
            }
        }

        public bool IsPalindrome(string s)
        {
            var low = 0;
            var high = s.Length - 1;
            while (low < high)
                if (s[low++] != s[high--]) return false;
            return true;
        }
    }
}
