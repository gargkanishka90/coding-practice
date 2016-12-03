using System;
using ScratchPad;

namespace ScratchPadTests
{
    public class AddTwoNumbersTest
    {
        public static void Run()
        {
            var list1 = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 2 , 4 , 3 });
            var list2 = LinkedListUtillities.GenerateSinglyLinkedListFromArray(new int[] { 5 , 6 , 4 });
            LinkedListUtillities.PrintSLL(AddTwoNumbers.Add(list1, list2));
            Console.WriteLine();
        }
    }
}