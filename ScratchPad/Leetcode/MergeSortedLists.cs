using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.Heap;

namespace ScratchPad.Leetcode
{
    public class MergeSortedLists
    {
        //Input: 1->2->4, 1->3->4
        //Output: 1->1->2->3->4->4
        public ListNode Merge(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            //l1.val <= l2.val ? l1 : l2;
            var runner1 = l1;
            var runner2 = l2;
            
            ListNode head = new ListNode(-1);
            ListNode runner = head;

            while (runner1 != null && runner2 != null)
            {
                if (runner1.val <= runner2.val)
                {
                    runner.next = runner1;
                    runner1 = runner1.next;
                }
                else
                {
                    runner.next = runner2;
                    runner2 = runner2.next;
                }

                runner = runner.next;
            }

            if (runner1 != null)
                runner.next = runner1;

            if (runner2 != null)
                runner.next = runner2;

            return head.next;
        }
    }
}
