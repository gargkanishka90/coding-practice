using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Heap.MedianFinder
{
    public class MedianFinder
    {
        internal class MinHeap
        {
            private List<int> _data;

            internal MinHeap()
            {
                _data = new List<int>();
            }

            internal int Count => _data.Count;

            internal void InsertKey(int key)
            {
                _data.Add(key);
                HeapifyUp(_data.Count - 1);
            }

            internal int PeekMin()
            {
                return _data.Count > 0 ? _data[0] : 0;
            }

            internal int ExtractMin()
            {
                var min = _data[0];
                _data[0] = _data[_data.Count - 1];
                _data.RemoveAt(_data.Count - 1);
                HeapifyDown(0);
                return min;
            }

            void HeapifyUp(int index)
            {
                while (index > 0)
                {
                    var parent = (index - 1) / 2;
                    if (_data[parent] > _data[index])
                    {
                        Swap(parent, index);
                        index = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            void HeapifyDown(int index)
            {
                var min = -1;
                var left = 2 * index + 1;
                var right = 2 * index + 2;

                if (left < _data.Count && _data[left] < _data[index])
                {
                    min = left;
                }
                else
                {
                    min = index;
                }

                if (right < _data.Count && _data[right] < _data[min])
                {
                    min = right;
                }

                if (min != index)
                {
                    Swap(min, index);
                    HeapifyDown(min);
                }
            }

            void Swap(int left, int right)
            {
                var temp = _data[left];
                _data[left] = _data[right];
                _data[right] = temp;
            }
        }

        internal class MaxHeap
        {
            private List<int> _data;

            internal MaxHeap()
            {
                _data = new List<int>();
            }

            internal int Count => _data.Count;

            internal void InsertKey(int key)
            {
                _data.Add(key);
                HeapifyUp(_data.Count - 1);
            }

            internal int PeekMax()
            {
                return _data.Count > 0 ? _data[0] : 0;
            }

            internal int ExtractMax()
            {
                var min = _data[0];
                _data[0] = _data[_data.Count - 1];
                _data.RemoveAt(_data.Count - 1);
                HeapifyDown(0);
                return min;
            }

            void HeapifyUp(int index)
            {
                while (index > 0)
                {
                    var parent = (index - 1) / 2;
                    if (_data[parent] < _data[index])
                    {
                        Swap(parent, index);
                        index = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            void HeapifyDown(int index)
            {
                var max = -1;
                var left = 2 * index + 1;
                var right = 2 * index + 2;

                if (left < _data.Count && _data[left] > _data[index])
                {
                    max = left;
                }
                else
                {
                    max = index;
                }

                if (right < _data.Count && _data[right] > _data[max])
                {
                    max = right;
                }

                if (max != index)
                {
                    Swap(max, index);
                    HeapifyDown(max);
                }
            }

            void Swap(int left, int right)
            {
                var temp = _data[left];
                _data[left] = _data[right];
                _data[right] = temp;
            }
        }

        private MinHeap minHeap;
        private MaxHeap maxHeap;

        public MedianFinder()
        {
            maxHeap = new MaxHeap();
            minHeap = new MinHeap();
        }

        public void AddNum(int num)
        {
            maxHeap.InsertKey(num);

            minHeap.InsertKey(maxHeap.ExtractMax());

            if (maxHeap.Count < minHeap.Count)
            {
                var min = minHeap.ExtractMin();
                maxHeap.InsertKey(min);
            }
        }

        public double FindMedian()
        {
            if (maxHeap.Count == minHeap.Count)
            {
                return (maxHeap.PeekMax() + minHeap.PeekMin()) / 2.0;
            }
            else
            {
                return maxHeap.PeekMax();
            }
        }
    }
}
