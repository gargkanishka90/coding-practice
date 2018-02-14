using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class PhoneNumberLetterCombination
    {
        public static IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            var numberToLetters = new[] {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

            if (string.IsNullOrEmpty(digits))
                return result;

            if (digits.Any(x => !char.IsDigit(x)))
                return result;

            LetterCombinationsHelper(digits, digits, "", result, numberToLetters);
            return result;
        }

        private static void LetterCombinationsHelper(string input, string seed, string prefix, List<string> result, string[] numberToLetters)
        {
            if (input.Length == prefix.Length)
            {
                result.Add(prefix);
            }
            else
            {
                foreach(var letter in numberToLetters[seed[0] - 48])
                {
                    LetterCombinationsHelper(input, seed.Substring(1), prefix + letter, result, numberToLetters);
                }
            }
        }
    }
}
