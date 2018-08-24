using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScratchPad.Heap
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class MergeKSortedLists
    {
        // head1 -> 1 -> 2 -> 3
        // head2 -> 7 -> 9 -> 11
        // head3 -> 4 -> 6 -> 10
        public ListNode MergeKLists(ListNode[] lists)
        {
            var dummyHead = new ListNode(-1);
            var runner = dummyHead;

            var minHeap = new MinHeap();

            for (var head = 0;  head < lists.Length; head++)
            {
                if (lists[head] != null)
                {
                    minHeap.Insert(new HeapItem()
                    {
                        data = lists[head].val,
                        listIndex = head
                    });
                    lists[head] = lists[head].next;
                }
            }

            while (minHeap.Count() > 0)
            {
                var minFromHeap = minHeap.ExtractMin();
                var minItemListNextNode = lists[minFromHeap.listIndex];
                if (minItemListNextNode != null)
                {
                    minHeap.Insert(new HeapItem()
                    {
                        data = minItemListNextNode.val,
                        listIndex = minFromHeap.listIndex
                    });
                    lists[minFromHeap.listIndex] = lists[minFromHeap.listIndex].next;
                }
                var node = new ListNode(minFromHeap.data);
                runner.next = node;
                runner = runner.next;
            }

            return dummyHead.next;
        }
    }

    public class HeapItem
    {
        public int data { get; set; }
        public int listIndex { get; set; }
    }

    public class MinHeap
    {
        private List<HeapItem> _heap;

        public int Count() => _heap.Count;

        public MinHeap()
        {
            _heap = new List<HeapItem>();
        }

        public void Insert(HeapItem newItem)
        {
            _heap.Add(newItem);
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            var index = _heap.Count - 1;

            while (index > 0)
            {
                var parentIndex = (index - 1) / 2;
                if (_heap[parentIndex].data > _heap[index].data)
                {
                    Swap(parentIndex, index);
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        public HeapItem ExtractMin()
        {
            var min = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            HeapifyDown(0);
            return min;
        }

        private void HeapifyDown(int index)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var min = -1;

            if (left < _heap.Count && _heap[left].data < _heap[index].data)
            {
                min = left;
            }
            else
            {
                min = index;
            }

            if (right < _heap.Count && _heap[right].data < _heap[min].data)
            {
                min = right;
            }

            if (min != index)
            {
                Swap(min, index);
                HeapifyDown(min);
            }
        }

        private void Swap(int left, int right)
        {
            var temp = _heap[left];
            _heap[left] = _heap[right];
            _heap[right] = temp;
        }
    }
}
