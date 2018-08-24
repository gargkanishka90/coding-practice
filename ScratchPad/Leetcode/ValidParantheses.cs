using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class ValidParantheses
    {
        //"()" and "()[]{}" are all valid but "(]" and "([)]" are not
        public bool IsValid(string s)
        {
            if (s.Length < 2) return false;

            var stack1 = new Stack<char>();

            var dict = new Dictionary<char, char>()
            {
                [')'] = '(',
                [']'] = '[',
                ['}'] = '{'
            };

            foreach (var character in s)
            {
                if (character == '(' || character == '[' || character == '{')
                {
                    stack1.Push(character);
                }

                if (character == ')' || character == ']' || character == '}')
                {
                    if (stack1.Pop() != dict[character])
                    {
                        return false;
                    }
                }
            }

            if (stack1.Count > 0) return false;

            return true;
        }
    }
}
