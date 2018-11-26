using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.Hashing
{
    public class FrequencySort
    {
        public static string Sort(string s)
        {
            StringBuilder sortedString = new StringBuilder();

            var freqMap = new Dictionary<char,int>();

            foreach (var ch in s)
            {
                if (freqMap.ContainsKey(ch))
                {
                    freqMap[ch] += 1;
                }
                else
                {
                    freqMap[ch] = 1;
                }
            }

            foreach (var pair in freqMap.OrderBy(kv => -kv.Value))
            {
                for (var i = 1; i <= pair.Value; i++)
                {
                    sortedString.Append(pair.Key);
                }
            }

            return sortedString.ToString();
        }

        public static string SortUsingHeap(string s)
        {
            StringBuilder sortedString = new StringBuilder();

            var freqMap = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (freqMap.ContainsKey(ch))
                {
                    freqMap[ch] += 1;
                }
                else
                {
                    freqMap[ch] = 1;
                }
            }

            var heap = new MaxFrequencyHeap<CharacterWithFrequency>();
            foreach (var kv in freqMap)
            {
                heap.Insert(new CharacterWithFrequency(kv.Key, kv.Value));
            }

            while (heap.Count > 0)
            {
                var top = heap.RemoveCharacterWithHighestFrequency();

                for (var i = 0; i < top.Frequency; i++)
                {
                    sortedString.Append(top.Character);
                }
            }

            return sortedString.ToString();
        }
    }

    public class MaxFrequencyHeap<TCharacterWithFrequency> where TCharacterWithFrequency : IComparable
    {
        public IList<TCharacterWithFrequency> data;
        public MaxFrequencyHeap()
        {
            data = new List<TCharacterWithFrequency>();
        }

        public void Insert(TCharacterWithFrequency item)
        {
            data.Add(item);
            HeapifyUp(data.Count - 1);
        }

        private void HeapifyUp(int i)
        {
            
            while (i > 0)
            {
                var parentIndex = (i - 1) / 2;
                if (data[parentIndex].CompareTo(data[i]) < 0)
                {
                    var temp = data[parentIndex];
                    data[parentIndex] = data[i];
                    data[i] = temp;
                    i = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown(int i)
        {
            var max = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < data.Count && data[left].CompareTo(data[max]) > 0)
            {
                max = left;
            }

            if (right < data.Count && data[right].CompareTo(data[max]) > 0)
            {
                max = right;
            }

            if (max != i)
            {
                var temp = data[i];
                data[i] = data[max];
                data[max] = temp;
                HeapifyDown(max);
            }
        }

        public int Count => data.Count;

        public TCharacterWithFrequency RemoveCharacterWithHighestFrequency()
        {
            var ret =  data.First();
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            HeapifyDown(0);
            return ret;
        }
    }

    public class CharacterWithFrequency : IComparable
    {
        public int Frequency { get; set; }
        public char Character { get; set; }

        public CharacterWithFrequency(char k, int f)
        {
            Frequency = f;
            Character = k;
        }

        public int CompareTo(CharacterWithFrequency other)
        {
            if (this.Frequency == other.Frequency)
                return this.Character.CompareTo(other.Character);

            return this.Frequency.CompareTo(other.Frequency);
        }

        public int CompareTo(object other)
        {
            if (this.Frequency == (other as CharacterWithFrequency).Frequency)
                return this.Character.CompareTo((other as CharacterWithFrequency).Character);

            return this.Frequency.CompareTo((other as CharacterWithFrequency).Frequency);
        }
    }
}