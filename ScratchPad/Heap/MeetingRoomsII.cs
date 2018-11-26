using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Heap
{
    public class MeetingRoomsII
    {
        public int MinMeetingRooms(Interval[] intervals)
        {
            Array.Sort(intervals, new Comparison<Interval>((i1,i2) => i2.start.CompareTo(i1.start)));
            var rooms = new MinHeap(int.MaxValue);
            foreach (var interval in intervals)
            {
                if (rooms.PeekMin() <= interval.start)
                {
                    rooms.ExtractMin();
                    rooms.InsertKey(interval.end);
                }
                else
                {
                    
                    rooms.InsertKey(interval.end);
                }
            }

            return rooms._data.Count;
        }

        public class Interval
        {
            public int start;
            public int end;

            public Interval()
            {
                start = 0;
                end = 0;
            }

            public Interval(int s, int e)
            {
                start = s;
                end = e;
            }
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

            public int PeekMin()
            {
                return _data.Count > 0 ? _data[0] : int.MinValue;
            }

            public int ExtractMin()
            {
                if (_data.Count == 0)
                    return -1;
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

        public class IntervalComparator : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                return x.start.CompareTo(y.start);
            }
        }
    }

    
}
