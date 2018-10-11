using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.Leetcode
{
    public class TopKFrequentWordFinder
    {
        public IList<string> Find(string[] words, int k)
        {
            var result = new List<string>();

            var wordToCount = new Dictionary<string, int>();

            foreach(var word in words){
                if (!wordToCount.ContainsKey(word))
                    wordToCount[word] = 0;
                wordToCount[word]++;
            }

            var myHeap = new MyMinHeap(k);

            // maintain a min-heap of size - K for storing most frequent words.
            foreach(var kv in wordToCount){
                var newItem = new Item(kv.Value, kv.Key);
                myHeap.Insert(newItem);
            }

            var x = myHeap._data.Select(i => i.word).Reverse();

            return x.ToList();
        }

        internal class Item : IComparable<Item> {
            public int count { get; set; }
            public string word { get; set; }

            internal Item(int count, string word){
                this.count = count;
                this.word = word;
            }

            public int CompareTo(Item other)
            {
                if (other == null)
                    return 1;

                if (count == other.count)
                    return other.word.CompareTo(word); // -1 if this < other, 0 if this == other, 1 if this > other
                return count - other.count > 0 ? 1 : -1;
            }

            public static bool operator > (Item item1, Item item2)
            {
                return item1.CompareTo(item2) == 1;
            }

            public static bool operator < (Item item1, Item item2)
            {
                return item1.CompareTo(item2) == -1;
            }
        }

        internal class MyMinHeap{
            public int size;
            public IList<Item> _data;

            internal MyMinHeap(int size){
                this.size = size;
                _data = new List<Item>();
            }

            public void Insert(Item newItem){
                if(_data.Count < size){
                    _data.Add(newItem);
                    HeapifyUp(_data.Count - 1);
                } 
                else 
                {
                    if (newItem > PeekMin())
                    {
                        // kick out min element
                        _data[0] = newItem;
                        HeapifyDown(0);
                    }
                }
            }

            private int LeftChild(int i) => 2 * i + 1;

            private int RightChild(int i) => 2 * i + 2;

            private int Parent(int i) => (i - 1)/2;

            private void HeapifyUp(int i)
            {
                while(i > 0){
                    if (_data[Parent(i)] > _data[i]){
                        var temp = _data[Parent(i)];
                        _data[Parent(i)] = _data[i];
                        _data[i] = temp;
                        i = Parent(i);
                    }
                    else{
                        break;
                    }
                }
            }

            private void HeapifyDown(int i)
            {
                var min = _data[i];
                var minIndex = i;

                if(LeftChild(i) < _data.Count && _data[LeftChild(i)] < min)
                {
                    minIndex = LeftChild(i);
                }

                if (RightChild(i) < _data.Count && _data[RightChild(i)] < min)
                {
                    minIndex = RightChild(i);
                }

                if(minIndex != i){
                    var temp = _data[i];
                    _data[i] = _data[minIndex];
                    _data[minIndex] = temp;
                    HeapifyDown(minIndex);
                }
            }

            Item PeekMin(){
                if(_data.Count > 0){
                    return _data[0];
                }
                return null;
            }
        }
    }
}
