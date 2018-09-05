using System;
using System.Collections.Generic;
using ScratchPad.Backtracking;
using ScratchPad.DesignPatterns.Builder;
using ScratchPad.Graphs;

namespace ScratchPadTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseSLLTest.Run();
            //RemoveDupsTest.Run();
            //TrieTest.Run();
            //UniqueCharactersTest.Run();
            //ReverseSubListTests.Run();
            // GenerateAllPermutationsTest.Run();
            //foreach (var x in PhoneNumberLetterCombination.LetterCombinationsIterative("6233525"))
            //{
            //    Console.WriteLine(x);
            //}
            //var board = new char[,]
            //{
            //    {'o', 'a', 'a', 'n'},
            //    {'e', 't', 'a', 'e'},
            //    {'i', 'h', 'k', 'r'},
            //    {'i', 'f', 'l', 'v'}
            //};
            // var dict = new [] { "oath", "pea", "eat", "rain" };
            // var f = new WordSearch2().FindWords(new char[,] { {'a'} }, new []{"a"});
            //MergeKSortedArraysTest.Run();
            //MedianFinderTest.Run();
            //SlidingWindowMaximumTest.Run();
            //DutchNationFlagTests.Run();
            //BuilderClient.TestBuilderPattern();
            //var instance = new PalindromePartition();

            //var nitin = instance.Partition("niaktkain");

            //var instance = new Subset();
            //var res = instance.Subsets(new[] {1, 2, 3});

            //var g = GraphUtils.GenerateSampleUndirectedGraph();
            //GraphUtils.PrintSampleGraph(g);
            //Console.WriteLine("--------------------------------");
            //var dg = GraphUtils.GenerateSampleDirectedGraph();
            //GraphUtils.PrintSampleGraph(dg);
            //Console.WriteLine(Search.BFS(dg, 1, 5));
            //Console.WriteLine(Search.BFS(dg, 3, 0));

            var g = GraphUtils.GenerateSampleUndirectedGraph();

            g.PrintAllVertices();
            g.PrintAllEdges();

            g.BFS();
        }
    }
}
