using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Backtracking
{
    public class GenerateParantheses
    {
        public IList<string> Generate(int n)
        {
            var result = new List<string>();

            // n = 1 -> "()"
            // n = 2 -> "()()", "(())"
            // n = 3 -> "()()()", (())()", "()(())", "(()())", "((()))"

            if (n == 1)
            {
                return new List<string>(){"()"};
            }

            var subResult = Generate(n - 1);

            for (var i = 0; i < subResult.Count; i++)
            {
                var current = subResult[i];
                for (var j = 0; j < current.Length; j++)
                {
                    var left = current.Substring(0, j);
                    var right = current.Substring(j);
                    var candidate = left + "()" + right;
                    if (IsValid(candidate))
                    {
                        if(!result.Contains(candidate))
                            result.Add(candidate);
                    }
                }
            }

            return result;
        }

        private bool IsValid(string s)
        {
            var st = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    st.Push(ch);
                }
                else if (ch == ')')
                {
                    if (st.Count == 0 || st.Peek() != '(')
                        return false;

                    st.Pop();
                }
            }

            return st.Count == 0;
        }
    }
}
