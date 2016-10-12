using System;
using ScratchPadTests.Leetcode;

namespace ScratchPad.Leetcode
{
    public class TwoSumTest
    {
        public static void Run()
        {
            var pairs = TwoSum.GetIndices(new [] {1, 1, 2, 3, 4}, 4);
            foreach (var item in pairs)
            {
                Console.WriteLine("At Position " + (item+1));
            }
            
            
        }
    }
}