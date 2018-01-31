using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class RemoveDupsTest
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 1, 1, 2, 3, 5, 2, 4 });
            LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            LinkedListUtillities.PrintSLL(RemoveDups.RemoveDuplicates(result));
        }
    }
}