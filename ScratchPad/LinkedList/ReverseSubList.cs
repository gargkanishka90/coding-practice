using System.ComponentModel;

namespace ScratchPad
{
    public class ReverseSubList
    {
        public static LinkNode Reverse(LinkNode root, int start, int finish)
        {
            var current = root;
            var ret = root;
            LinkNode prev = null;
            var i = 1;

            while (i++ < start)
            {
                prev = current;
                current = current.Next;
            }

            var startCheckPoint = prev;
            var endCheckPoint = current;

            while (start++ < finish)
            {
                var tmp = current.Next;
                current.Next.SetNext(current);
                current = tmp;
                //prev.SetNext(current);
                //urrent = tmp;
            }
            endCheckPoint.SetNext(current.Next);
            current.SetNext(startCheckPoint);
            return ret;
        } 
    }
}