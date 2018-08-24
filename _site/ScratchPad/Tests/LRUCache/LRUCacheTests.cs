using System;
using System.Runtime.InteropServices;

namespace ScratchPad.LRUCache
{
    public class LRUCacheTests
    {
        public static void Run()
        {
            var x = new LRUCache3(5);
            x.Set(1,10);
            x.Set(2,20);
            x.Set(3,30);
            x.Set(4,40);
            x.Set(5,50);
            x.Print();
            x.Set(6,60);
            x.Print();
            x.Set(7,70);
            x.Print();
            int data;
            x.Get(4, out data);
            Console.WriteLine(x.head.data);
            int data1;
            x.Get(5, out data1);
            Console.WriteLine(x.head.data);
        } 
    }
}