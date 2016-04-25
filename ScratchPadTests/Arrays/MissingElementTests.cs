using System;

namespace ScratchPad.Arrays
{
    public class MissingElementTests
    {
        public static void Run()
        {
            var arr1 = new int[] {1,2,3,4};
            var arr2 = new int[] {1,2,3};
            Console.WriteLine(MissingElement.Find2(arr1, arr2));
        } 
    }
}