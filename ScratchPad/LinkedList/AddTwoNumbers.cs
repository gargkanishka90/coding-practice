namespace ScratchPad
{
    public class AddTwoNumbers
    {
        public static LinkNode Add(LinkNode head1, LinkNode head2)
        {
            var headcopy1 = head1;
            var headcopy2 = head2;
            var carryOver = 0;
            var dummyHead = new LinkNode(0);
            var current = dummyHead;

            while (headcopy1 != null || headcopy2 != null)
            {
                var first = headcopy1?.Data ?? 0;
                var second = headcopy2?.Data ?? 0;

                var sum = first + second + carryOver;

                carryOver = sum%10;

                current.SetNext(new LinkNode(sum%10));
                current = current.Next;

                if (headcopy1 != null) headcopy1 = headcopy1.Next;
                if (headcopy2 != null) headcopy2 = headcopy2.Next;
            }

            if (carryOver > 0)
            {
                current.Next = new LinkNode(carryOver);
            }

            return dummyHead.Next;
        }
    }
}