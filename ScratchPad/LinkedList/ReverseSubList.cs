using System.CodeDom.Compiler;
using System.ComponentModel;

namespace ScratchPad
{
    public class ReverseSubList
    {
        public static LinkNode Reverse(LinkNode root, int start, int finish)
        {
            var current = root;
            var dummy = root;
            LinkNode prev = null;
            var i = 1;

            while (i++ < start)
            {
                prev = current;
                current = current.Next;
            }

            //var startCheckPoint = prev;
            var startCheckPoint = current;

            while (start++ < finish)
            {
                var tmp = current.Next;
                current.SetNext(null);
                tmp.Next = current;
                current = tmp;
            }
            prev.Next = current;
            startCheckPoint.Next = current.Next;
            return dummy;
        } 
    }
}