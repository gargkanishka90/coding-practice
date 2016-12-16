using System;
using System.Xml;
using ScratchPad;

namespace ScratchPadTests
{
    public class LinkedListCycleTests
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 1, 1, 2, 3, 5, 2, 4 });
            //LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            //LinkedListUtillities.PrintSLL(RemoveDups.RemoveDuplicates(result));
            Console.WriteLine(LinkedListCycle.IsCyclePresent(result));
            Console.WriteLine(LinkedListCycle.IsCyclePresent2(result));
        }
    }
}