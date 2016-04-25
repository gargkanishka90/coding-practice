using System;
using ScratchPad.String;

namespace ScratchPadTests
{
    public class GenerateAllPermutationsTest
    {
        public static void Run()
        {
            string[] words = { "abc" };
            var result = GenerateAllPermutations.permutations(words[0]);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            //Console.Read();
            
        }
    }
}