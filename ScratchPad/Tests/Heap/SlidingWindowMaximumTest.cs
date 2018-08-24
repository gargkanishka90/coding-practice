using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.Heap;

namespace ScratchPad.Tests.Heap
{
    public class SlidingWindowMaximumTest
    {
        public static void Run()
        {
            var instance = new SlidingWindowMaximum();
            var a = instance.MaxSlidingWindow(new[] {1, 3, -1, -3, 5, 3, 6, 7}, 3);
        }
    }
}
