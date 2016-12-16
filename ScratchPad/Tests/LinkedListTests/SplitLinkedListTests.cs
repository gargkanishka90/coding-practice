using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class SplitLinkedListTests
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 1, 1, 2, 3, 5, 2, 4 });
            LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            var result2 = SplitLinkedList.Split(result);
            LinkedListUtillities.PrintSLL(result2[0]);
            Console.WriteLine();
            LinkedListUtillities.PrintSLL(result2[1]);
        }
    }
}