using System;
using System.Collections.Generic;
using ScratchPad.String;

namespace ScratchPadTests
{
    public class ReplaceCharsTest
    {
        public static void Run()
        {
            var res = ReplaceChars.Replace("kanishka");
            foreach (var v in res)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(res.Count);
        }


    }
}