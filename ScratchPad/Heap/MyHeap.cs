using System;
using System.Collections.Generic;

namespace ScratchPadTests.Heap
{
    public class MyHeap<T> : IMyHeap<T> where T : IComparable
    {
        private readonly List<T> _list = new List<T>();

        private void Swap(int first, int second)
        {
            var temp = _list[first];
            _list[first] = _list[second];
            _list[second] = temp;
        }

        private static int Parent(int i) => (i - 1)/2;

        private static int LeftChild(int i) => 2*i + 1;

        private static int RightChild(int i) => 2*i + 2;

        private void MinHeapify(int i)
        {
            int smallest;
            var left = LeftChild(i);
            var right = RightChild(i);

            if (left < _list.Count && _list[left].CompareTo(_list[i]) < 0)
            {
                smallest = left;
            }
            else
            {
                smallest = i;
            }

            if (right < _list.Count && _list[right].CompareTo(_list[smallest]) < 0)
            {
                smallest = right;
            }

            if (smallest != i)
            {
                Swap(smallest,i);
                MinHeapify(smallest);
            }
        }

        private void HeapifyUp(int i)
        {
            while (i > 0)
            {
                if (_list[i].CompareTo(_list[Parent(i)]) < 0)
                {
                    Swap(i, Parent(i));
                    i = Parent(i);
                }
                else
                {
                    break;
                }
            }    
        }
         
        public T ExtractMin()
        {
            if(_list.Count < 0) throw new Exception("List is empty.");

            var result = _list[0];
            _list[0] = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            MinHeapify(0);
            return result;
        }

        public T PeekMin()
        {
            return _list[0];
        }

        public void DecreaseKey(int i, T newValue)
        {
            _list[i] = newValue;
            HeapifyUp(i);
        }

        public void Insert(T newValue)
        {
            _list.Add(newValue);
            HeapifyUp(_list.Count - 1);
        }

        public void DeleteKey(int i)
        {
            DecreaseKey(i, PeekMin());
            ExtractMin();
        }
    }
}