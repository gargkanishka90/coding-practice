using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.Heap.MedianFinder;

namespace ScratchPad.Tests.Heap
{
    public class MedianFinderTest
    {
        public static void Run()
        {
            var instance = new MedianFinder();
            instance.AddNum(-1);
            Console.WriteLine(instance.FindMedian());
            instance.AddNum(-2);
            Console.WriteLine(instance.FindMedian());
            instance.AddNum(-3);
            Console.WriteLine(instance.FindMedian());
        }
    }
}
