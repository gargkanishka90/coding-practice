using System;

namespace ScratchPad.Tests.LinkedListTests
{
    public class ReverseSLLTest
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 1, 1, 2, 3, 5, 2, 4 });
            LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            //LinkedListUtillities.PrintSLL(RemoveDups.RemoveDuplicates(result));
            LinkedListUtillities.PrintSLL(ReverseSLL.Reverse(result));
        } 
    }
}