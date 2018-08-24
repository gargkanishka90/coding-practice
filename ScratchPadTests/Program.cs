using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using PracticePad.Leetcode;
using ScratchPad.Arrays;
using ScratchPad.Backtracking;
using ScratchPad.BinaryTree;
using ScratchPad.DesignPatterns;
using ScratchPad.DesignPatterns.TemplateMethod;
using ScratchPad.DynamicProgramming;
using ScratchPad.Heap;
using ScratchPad.Leetcode;
using ScratchPad.LRUCache;
using ScratchPad.Searching;
using ScratchPadTests;
using ScratchPadTests.BinaryTree;
using ScratchPadTests.Heap;

namespace ScratchPad
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseSLLTest.Run();
            //RemoveDupsTest.Run();
            //TrieTest.Run();
            //UniqueCharactersTest.Run();
            // ReverseSubListTests.Run();
            //GenerateAllPermutationsTest.Run();
            //ArrayPairSumTests.Run();
            //MaxContiguousSubArrayTests.Run();
            // MissingElementTests.Run();
            //ReplaceCharsTest.Run();
            //InsertCharsTest.Run();
            //SplitLinkedListTests.Run();
            //LinkedListCycleTests.Run();
           // DeleteMafterEveryNTest.Run();
           //FindFirstUniqueCharacterTest.Run();
           //MatrixZeroTests.Run();
           //PreOrderTest.Run();
           //LRUCacheTests.Run();
           //InvertedIndexTests.Run();
           //TwoSumTest.Run();
           //AddTwoNumbersTest.Run();
           //MergeKSortedArraysTest.Run();
           //BubbleSortTest.Run();
           //StrategyPatternWiki.Run();
           //TemplateMethodPattern.Run();
            //NumberOfOneBits.HammingWeight(11);
            //BitManipulationClass.HammingDistance(4, 2);
           // BitManipulationClass.reverseBits(43261596);
           //ArrayRotation.Rotate(new []{1,2,3,4,5,6,7}, 3);

            var mat = new int[,]
            {
                {15, 13, 2, 5},
                {14, 3, 4, 1},
                {12, 6, 8, 9},
                {16, 7, 10, 11}
            };
            //ArrayRotation.Rotate(mat);
          // var tr = TreeHelpers.CreateRandomTree();
           // var res = TreeHelpers.LevelOrder(tr);
           //TraversalHelpers.InOrderTraversal(tr);
           //TraversalHelpers.PostOrderTraversal(tr);
            //var height = TreeHelpers.Height(tr);
            //TraversalHelpers.LevelOrderTraveral2(tr);

            //var tr = TreeUtilities.SortedArrayToBST(new[] {1, 2, 3, 4, 5, 6});
            //var path = TraversalHelpers.PreOrderIterative(tr);
            //var pathRec = TraversalHelpers.PreOrderTraversal(tr);
            //var w = path.SequenceEqual(pathRec);
            //var shuff = new ArrayShuffle(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
            //Console.WriteLine(shuff.Shuffle());
            //Console.WriteLine(shuff.Shuffle());
            //Console.WriteLine(shuff.Reset());
            //onsole.WriteLine(shuff.Shuffle());

            var board = new char[,]
            {
                {'c', 'a', 'a'},
                {'a', 'a', 'a'},
                {'b', 'c', 'd'}
            };

            //[["C","A","A"],["A","A","A"],["B","C","D"]]
            //"AAB"

            //WordSearch.Exist(board, "aab");
           var sss = new Powerset().Generate1(new []{1,2,3,4});
            foreach (var x in sss)
            {
                Console.WriteLine(string.Join(",", x));
            }
            var matrix = new int[,]
            {
                {1, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 1}
            };

            //var path = RobotPath.GetPath(matrix);
            //path.ToList().ForEach(p => Console.WriteLine($"({p.x},{p.y})"));

            //var len = LIS.LISLength(new int[] {10, 9, 2, 5, 3, 7, 101, 18});
            //var normal = NormalizePath.SimplifyPath("/..");

            //var subs = WordBreakProblem.WordBreak("ilikelikeiiiicemango",
            //    new[]
            //    {
            //        "i", "like", "sam", "sung", "samsung", "mobile", "ice", "cream", "icecream", "man", "go", "mango"
            //    });


            

            //LCSHelpers.LCS("AGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABACAGGTABABABABABABABAC", "GXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABAGXTXAYBABABABAAAABABABABA");
            //lcs = LCS.Recursive("abcbdababcabcaababababababababababbaababbababababbaabababbbababababbab", "bdcabaabababababababababababaabababababababsbsbbsbababba");

            //var test = "ATAGactcatagctac".AllSubSequences();
            var t = LongestRepeatedSubsequence.Find("AAB");
        }
    }
}
