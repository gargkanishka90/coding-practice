using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Utils
{
    public static class PrintUtils
    {
        public static void PrintList<T>(IEnumerable<T> iterable)
        {
            foreach (var item in iterable)
            {
                Console.Write(item + " , ");
            }
        }
    }
}
