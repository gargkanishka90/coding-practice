using System;
using System.Collections.Generic;

namespace ScratchPad.Heap
{
    public class FindKthLargestElement
    {
        public int Find(int[] nums, int k)
        {
            var minHeap = new MinHeap(k);

            foreach (var num in nums)
            {
                minHeap.Insert(num);
            }

            return minHeap.PeekMin();
        }

        public class MinHeap
        {
            public IList<int> _data;
            public int size;

            public MinHeap(int k)
            {
                _data = new List<int>();
                size = k;
            }

            public void Insert(int key)
            {
                if (_data.Count < size)
                {
                    _data.Add(key);
                    HeapifyUp(_data.Count - 1);
                }
                else
                {
                    if (key > PeekMin())
                    {
                        _data[0] = key;
                        HeapifyDown(0);
                    }
                }
            }

            public void HeapifyUp(int i)
            {

                while (i > 0)
                {
                    var parent = (i - 1) / 2;
                    if (_data[parent] > _data[i])
                    {
                        var temp = _data[parent];
                        _data[parent] = _data[i];
                        _data[i] = temp;
                        i = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public void HeapifyDown(int i)
            {
                var left = 2 * i + 1;
                var right = 2 * i + 2;
                var min = i;

                if (left < _data.Count && _data[left] < _data[min])
                {
                    min = left;
                }

                if (right < _data.Count && _data[right] < _data[min])
                {
                    min = right;
                }

                if (min != i)
                {
                    var temp = _data[i];
                    _data[i] = _data[min];
                    _data[min] = temp;
                    HeapifyDown(min);
                }
            }

            public int PeekMin()
            {
                return _data[0];
            }
        }
    }
}
