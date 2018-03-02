using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class NormalizePath
    {
        public static string SimplifyPath(string path)
        {
            if (path == null) return null;

            var entries = path.Split('/');
            var st = new Stack<string>();

            foreach (var entry in entries)
            {
                if (entry == ".." && st.Count > 0)
                {
                    st.Pop();
                }

                else if (entry != "." && entry != "")
                {
                    st.Push(entry);
                }
            }

            var res = "";
            while (st.Count > 0)
            {
                res = "/" + st.Pop() + res;
            }

            return res == "" ? "/" : res;
        }
    }
}
