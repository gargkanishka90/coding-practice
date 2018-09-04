using System;
using System.Collections.Generic;
using ScratchPad.Arrays;

namespace ScratchPad.Tests.Arrays
{
    public class DutchNationFlagTests
    {
        
        public static void Run()
        {
            var dnf = new DutchNationalFlag();
            var arr1 = new int[80000];
            var r = new Random();
            for (var index = 0; index < arr1.Length; index++){
                arr1[index] = r.Next(0, 3);
            }
            var st = DateTime.Now;
            dnf.Arrange(arr1, 1);
            var end = DateTime.Now;
            Console.WriteLine((end - st).TotalMilliseconds);

            for (var index = 0; index < arr1.Length; index++)
            {
                arr1[index] = r.Next(0, 3);
            }

            st = DateTime.Now;
            dnf.Arrange2(arr1, 1);
            end = DateTime.Now;
            Console.WriteLine((end - st).TotalMilliseconds);

            var count = new Dictionary<int, int>();
            count[0] = 0;
            count[1] = 0;
            count[2] = 0;
            foreach(var elem in arr1){
                count[elem]++;
            }
            Console.WriteLine(0 + "," + count[0]);
            Console.WriteLine(1 + "," + count[1]);
            Console.WriteLine(2 + "," + count[2]);
            Console.WriteLine(count[0] + count[1] + count[2]);
        }

    }
}
