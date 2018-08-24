using System.Collections.Generic;
using System.Linq;

namespace ScratchPad
{
    public class RemoveDups
    {
        public static LinkNode RemoveDuplicates(LinkNode root)
        {
            var head = root;
            LinkNode previous = null;
            var table = new Dictionary<int, bool>();

            while (root != null)
            {
                if (!table.Keys.Contains(root.Data))
                {
                    table[root.Data] = true;
                    previous = root;
                }
                else
                {
                    if (previous != null)
                    {
                        previous.Next = root.Next;
                    }
                }
                root = root.Next;
            }
            return head;
        }
    }
}