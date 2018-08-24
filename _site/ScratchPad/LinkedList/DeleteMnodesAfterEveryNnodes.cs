namespace ScratchPad
{
    public class DeleteMnodesAfterEveryNnodes
    {
        public static LinkNode Delete(LinkNode head, int m, int n)
        {
            var runner = head;

            while (runner != null)
            {
                int i = 0;
                while (runner != null && i < n - 1)
                {
                    runner = runner.Next;
                    i++;
                }

                if (runner == null)
                {
                    break;
                }

                var temp = runner.Next;

                int j = 0;
                while ( j < m && temp != null)
                {
                    j++;
                    temp = temp.Next;
                }

                runner.Next = temp;
                runner = temp;
            }
            return head;
        } 
    }
}