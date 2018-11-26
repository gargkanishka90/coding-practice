using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Hashing
{
    //public class LFUCache
    //{
    //    private Dictionary<int, int> cache;
    //    private MinHeap<Item> heap;
    //    private int cap;
    //    private DateTimeOffset dto;

    //    public LFUCache(int capacity)
    //    {
    //        cap = capacity;
    //        cache = new Dictionary<int, int>();
    //        heap = new MinHeap<Item>(capacity);
    //        dto = new DateTimeOffset(DateTime.UtcNow);
    //    }

    //    public int Get(int key)
    //    {
    //        if (cache.ContainsKey(key))
    //        {
    //            //UpdateAccessTime(key);
    //            return cache[key];
    //        }

    //        return -1;
    //    }

    //    public void Put(int key, int value)
    //    {
    //        if (!cache.ContainsKey(key))
    //        {
    //            if (cache.Count < cap)
    //            {
    //                cache[key] = value;
    //                heap.InsertKey(new Item(key, 1, dto.UtcTicks));
    //            }
    //            else
    //            {
    //                var min = heap.ExtractMin();
    //                cache.Remove(min.Key);
    //                cache[key] = value;
    //                heap.InsertKey(new Item(key, 1, dto.UtcTicks));
    //            }
    //        }  
    //    }

    //    public class Item : IComparable<Item>, IComparable
    //    {
    //        public int Key { get; set; }

    //        public int Count { get; set; }

    //        public long AccessTime { get; set; }

    //        public Item(int k, int count, long ticks)
    //        {
    //            Key = k;
    //            Count = count;
    //            AccessTime = ticks;
    //        }

    //        public int CompareTo(Item other)
    //        {
    //            if (this.Count == other.Count)
    //            {
    //                return this.AccessTime.CompareTo(other.AccessTime);
    //            }
    //            else
    //            {
    //                return Count.CompareTo(other.Count);
    //            }
    //        }

    //        public int CompareTo(object other)
    //        {
    //            if (this.Count == (other as Item).Count)
    //            {
    //                return this.AccessTime.CompareTo((other as Item).AccessTime);
    //            }
    //            else
    //            {
    //                return Count.CompareTo((other as Item).Count);
    //            }
    //        }
    //    }

    //    public class MinHeap<Item> where Item : IComparable
    //    {
    //        public IList<Item> _data;
    //        public int size;

    //        public MinHeap(int k)
    //        {
    //            _data = new List<Item>();
    //            size = k;
    //        }

    //        public Item PeekMin()
    //        {
    //            return _data[0];
    //        }

    //        public Item ExtractMin()
    //        {
    //            var temp = _data[0];
    //            _data[0] = _data[_data.Count - 1];
    //            _data.RemoveAt(_data.Count - 1);
    //            HeapifyDown(0);
    //            return temp;
    //        }

    //        public bool InsertKey(Item key)
    //        {
    //            if (_data.Count < size)
    //            {
    //                _data.Add(key);
    //                HeapifyUp(_data.Count - 1);
    //            }
    //            else
    //            {
    //                if (key.CompareTo(PeekMin()) > 0)
    //                {
    //                    _data[0] = key;
    //                    HeapifyDown(0);
    //                }
    //            }

    //            return true;
    //        }

    //        private void HeapifyDown(int i)
    //        {
    //            var left = 2 * i + 1;
    //            var right = 2 * i + 2;
    //            var min = i;

    //            if (left < _data.Count && _data[left].CompareTo(_data[min]) < 0)
    //            {
    //                min = left;
    //            }

    //            if (right < _data.Count && _data[right].CompareTo(_data[min]) < 0)
    //            {
    //                min = right;
    //            }

    //            if (min != i)
    //            {
    //                Swap(min, i);
    //                HeapifyDown(min);
    //            }
    //        }

    //        private void Swap(int a, int b)
    //        {
    //            var temp = _data[a];
    //            _data[a] = _data[b];
    //            _data[b] = temp;
    //        }

    //        private void HeapifyUp(int i)
    //        {
    //            while (i > 0)
    //            {
    //                if (_data[Parent(i)].CompareTo(_data[i]) > 0)
    //                {
    //                    Swap(Parent(i), i);
    //                    i = Parent(i);
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //        }

    //        private int Parent(int i)
    //        {
    //            return (i - 1) / 2;
    //        }
    //    }
    //}
}
