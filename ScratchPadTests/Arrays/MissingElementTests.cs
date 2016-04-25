using System;

namespace ScratchPad.Arrays
{
    public class MissingElementTests
    {
        public static void Run()
        {
            var arr1 = new int[] {1};
            var arr2 = new int[] {};
            Console.WriteLine(MissingElement.Find(arr1, arr2));
        } 
    }
}