using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Heap
{
    public class SlidingWindowMaximum
    {
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

            internal void RemoveKey(int key)
            {
                var index = _data.FindIndex(x => x == key);
                Swap(index, _data.Count - 1);
                _data.RemoveAt(_data.Count - 1);
                HeapifyDown(index);
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

            internal void Clear()
            {
                _data.Clear();
            }
        }
        //Given an array nums, there is a sliding window of size k which is moving from the very left of 
        //the array to the very right.You can only see the k numbers in the window. Each time the sliding 
        //window moves right by one position.

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var N = nums.Length;
            var result = new int[N - k + 1];
            var maxHeap = new MaxHeap();

            for (var i = 0; i < k; i++)
            {
                maxHeap.InsertKey(nums[i]);
            }

           // var j = 0;
           // var toRemove = nums[j];
            result[0] = maxHeap.PeekMax();
            for (var pos = k; pos < N ; pos++)
            {
                maxHeap.RemoveKey(nums[pos-k]);
                maxHeap.InsertKey(nums[pos]);
                result[pos-k+1] = maxHeap.PeekMax();
            }

            //result[0] = queue.peek();
            //for (int i = k; i < len; i++)
            //{
            //    queue.remove(nums[i - k]);
            //    queue.add(nums[i]);
            //    result[i - k + 1] = queue.peek();
            //}

            //result[j] = maxHeap.PeekMax();

            return result;
        }

        public int[] MaxSlidingWindow2(int[] nums, int k)
        {
            var N = nums.Length;
            var result = new int[N-k+1];
            var maxHeap = new MaxHeap();

            var j = 0;
            for (var i = 0; i <= (N - k); i++)
            {
                PopulateMaxHeap(maxHeap, i, k, nums);
                var maxInCurrentWindow = maxHeap.PeekMax();
                result[j++] = maxInCurrentWindow;
                maxHeap.Clear();
            }

            return result;
        }

        private void PopulateMaxHeap(MaxHeap maxHeap, int start, int k, int[] nums)
        {
            for (var i = start; i < start + k; i++)
            {
                maxHeap.InsertKey(nums[i]);
            }
        }
    }
}
