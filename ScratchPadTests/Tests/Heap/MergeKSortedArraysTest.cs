using System;
using System.Collections.Generic;
using ScratchPadTests.Heap;

namespace ScratchPad.Heap
{
    public class MergeKSortedArraysTest
    {
        public static void Run()
        {
            var sortedArrays = new List<List<int>>()
            {
                new List<int>()
                {
                    3,5,7
                },
                new List<int>()
                {
                    0,6
                },
                new List<int>()
                {
                    0,
                    6,
                    28
                }
            };

            //var result = MergeKSortedArrays.MergeSortedFiles(sortedArrays);
            Console.WriteLine();

            
            var head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);

            var head2 = new ListNode(7);
            head2.next = new ListNode(9);
            head2.next.next = new ListNode(11);

            var head3 = new ListNode(5);
            head3.next = new ListNode(8);
            head3.next.next = new ListNode(10);

            var sortedLists = new ListNode[]
            {
                head1,
                head2,
                head3
            };
            sortedLists[0] = head1;
            sortedLists[1] = head2;
            sortedLists[2] = head3;

            var result2 = new MergeKSortedLists().MergeKLists(sortedLists);

            while(result2.next != null){
                Console.WriteLine(result2.val);
                result2 = result2.next;
            }
        }
    }
}