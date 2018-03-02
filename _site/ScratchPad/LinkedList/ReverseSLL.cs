namespace ScratchPad
{
    public class ReverseSLL
    {
        public static LinkNode Reverse(LinkNode root)
        {
            var current = root;
            LinkNode prev = null;
            while (current.Next != null)
            {
                var next = current.Next;
                current.SetNext(prev);
                prev = current;
                current = next;
            }
            current.SetNext(prev);
            return current;
        } 
    }
}