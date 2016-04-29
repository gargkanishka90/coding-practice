using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class DeleteMafterEveryNTest
    {
        public static void Run()
        {
            var result = LinkedListUtillities.GenerateSinglyLinkedListFromArray(
                new int[] { 1, 1, 2, 3, 5, 2, 4 , 7, 8});
            LinkedListUtillities.PrintSLL(result);
            Console.WriteLine();
            //LinkedListUtillities.PrintSLL(RemoveDups.RemoveDuplicates(result));
            LinkedListUtillities.PrintSLL(DeleteMnodesAfterEveryNnodes.Delete(result,5,2));
            //Console.WriteLine(LinkedListCycle.IsCyclePresent2(result));
        } 
    }
}