using System;
using ScratchPad.String;

namespace ScratchPad.Tests.StringTests
{
    public class UniqueCharactersTest
    {
        public static void Run()
        {
            string[] words = { "abcd", "aabc", "xycc" };
            foreach (var word in words)
            {
                Console.WriteLine(word + " " + UniqueCharacters.IsUnique(word));
                Console.WriteLine(word + " " + UniqueCharacters.IsUnique2(word));
            }
            //Console.Read();
        }
    }
}