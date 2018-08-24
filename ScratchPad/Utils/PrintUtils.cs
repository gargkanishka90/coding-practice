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
            var list = iterable.ToList();
            if(list.Count == 0) return;
            for (var i = 0; i < list.Count-1; i++)
            {
                Console.Write(list[i] + " , ");
            }
            Console.Write(list[list.Count-1]);
        }
    }
}
