using System;
using ScratchPad.String;

namespace ScratchPadTests
{
    public class FindFirstUniqueCharacterTest
    {
        public static void Run()
        {
            var input = "abcabcabcabcabcabcw";
            Console.WriteLine("First Non-Repeated Character: " + FindFirstUniqueCharacter.Find(input));
        } 
    }
}