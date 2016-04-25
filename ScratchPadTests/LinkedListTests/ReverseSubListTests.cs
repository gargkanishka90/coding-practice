using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class ReverseSubListTests
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 1, 2,3,4,5,6,7,8 });
            LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            LinkedListUtillities.PrintSLL(ReverseSubList.Reverse(result,3,6));
        }
    }
}