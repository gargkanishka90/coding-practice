using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Heap
{
    public class MyHeap2
    {
        public class MinHeap
        {
            private IList<int> _data;
            private int size;
            public MinHeap(int k)
            {
                _data = new List<int>();
                size = k;
            }

            public int PeekMin()
            {
                return _data[0];
            }

            public int ExtractMin()
            {
                var temp = _data[0];
                _data[0] = _data[_data.Count - 1];
                _data.RemoveAt(_data.Count-1);
                HeapifyDown(0);
                return temp;
            }

            public bool InsertKey(int key)
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

                return true;
            }

            private void HeapifyDown(int i)
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
                    Swap(min, i);
                    HeapifyDown(min);
                }
            }

            private void Swap(int a, int b)
            {
                var temp = _data[a];
                _data[a] = _data[b];
                _data[b] = temp;
            }

            private void HeapifyUp(int i)
            {
                while (i > 0)
                {
                    if (_data[Parent(i)] > _data[i])
                    {
                        Swap(Parent(i), i);
                        i = Parent(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            private int Parent(int i)
            {
                return (i - 1) / 2;
            }
        }

        public class MaxHeap
        {
            private IList<int> _data;
            private int size;
            public MaxHeap(int k)
            {
                _data = new List<int>();
                size = k;
            }

            public int PeekMax()
            {
                return _data[0];
            }

            public int ExtractMax()
            {
                var temp = _data[0];
                _data[0] = _data[_data.Count - 1];
                _data.RemoveAt(_data.Count - 1);
                HeapifyDown(0);
                return temp;
            }

            public bool InsertKey(int key)
            {
                if (_data.Count < size)
                {
                    _data.Add(key);
                    HeapifyUp(_data.Count - 1);
                }
                else
                {
                    if (key < PeekMax())
                    {
                        _data[0] = key;
                        HeapifyDown(0);
                    }
                }

                return true;
            }

            private void HeapifyDown(int i)
            {
                var left = 2 * i + 1;
                var right = 2 * i + 2;
                var min = i;

                if (left < _data.Count && _data[left] > _data[min])
                {
                    min = left;
                }

                if (right < _data.Count && _data[right] > _data[min])
                {
                    min = right;
                }

                if (min != i)
                {
                    Swap(min, i);
                    HeapifyDown(min);
                }
            }

            private void Swap(int a, int b)
            {
                var temp = _data[a];
                _data[a] = _data[b];
                _data[b] = temp;
            }

            private void HeapifyUp(int i)
            {
                while (i > 0)
                {
                    if (_data[Parent(i)] < _data[i])
                    {
                        Swap(Parent(i), i);
                        i = Parent(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            private int Parent(int i)
            {
                return (i - 1) / 2;
            }
        }
    }
}
