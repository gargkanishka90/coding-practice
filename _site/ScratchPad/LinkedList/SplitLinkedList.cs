using System.Collections.Generic;

namespace ScratchPad
{
    public class SplitLinkedList
    {
        public static List<LinkNode> Split(LinkNode head)
        {
            var slow = head;
            var fast = head;
            LinkNode end = null;

            while (fast != null)
            {
                end = slow;
                slow = slow.Next;
                fast = fast.Next?.Next;
            }

            end.Next = null;
            return new List<LinkNode>
            {
               head , slow
            };
        } 
    }
}