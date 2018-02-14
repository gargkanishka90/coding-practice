using System;
using ScratchPad.String;

namespace ScratchPadTests
{
    public class GenerateAllPermutationsTest
    {
        //public static void Run()
        //{
        //    string[] words = { "abcdefghij" };
        //    var result = GenerateAllPermutations.GetPermutations(words[0]);
        //    foreach (var word in result)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    //Console.Read();
        //    Console.WriteLine("Total Permutations: " + result.Count);
            
        //}

        public static void Run()
        {
            //string[] words = { "abcde" };
            //var result = GenerateAllPermutations.FindPermutations(words[0]);
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            ////Console.Read();
            //Console.WriteLine("Total Permutations: " + result.Count);

            int[] nums = { 1, 1, 2 };
            var result = GenerateAllPermutations.PermuteUnique(nums);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            //Console.Read();
            Console.WriteLine("Total Permutations: " + result.Count);

        }
    }
}