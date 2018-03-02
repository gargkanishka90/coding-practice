using System;
using ScratchPad.String;

namespace ScratchPadTests
{
    public class InsertCharsTest
    {
        public static void Run()
        {
            var res = InsertChars.Insert("aaaaa");
            foreach (var v in res)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(res.Count);
        }
    }
}