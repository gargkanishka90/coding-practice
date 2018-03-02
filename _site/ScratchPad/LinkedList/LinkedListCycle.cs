using System.Collections.Generic;
using System.Xml;
using ScratchPad;

namespace ScratchPad
{
    public class LinkedListCycle
    {
        public static bool IsCyclePresent(LinkNode head)
        {
            var result = false;
            var table = new Dictionary<LinkNode, bool>();
            var current = head;

            while (current != null)
            {
                if (!table.ContainsKey(current))
                {
                    table[current] = true;
                }
                else
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public static bool IsCyclePresent2(LinkNode head)
        {
            var slow = head;
            var fast = head;

            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}