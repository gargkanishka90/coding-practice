using System;
using System.Collections.Generic;

namespace ScratchPadTests.Heap
{
    public class MergeKSortedArrays
    {
        public static List<int> MergeSortedFiles(List<List<int>> sortedFiles)
        {
            var result = new List<int>();

            // use MyHeap as a min-heap
            var minHeap = new MyHeap<ArrayEntry>();
            
            var headMap = new Dictionary<int, int>();

            // put each sorted array's first element into minHeap
            for (var i = 0; i < sortedFiles.Count; ++i)
            {
                if (sortedFiles[i].Count > 0)
                {
                    minHeap.Insert(new ArrayEntry(i, sortedFiles[i][0]));
                    headMap.Add(i, 1);
                }
                else
                {
                    headMap.Add(i, 0);
                }
            }

            ArrayEntry headEntry;
            while ((headEntry = minHeap.ExtractMin()) != null)
            {
                result.Add(headEntry._value);

                var smallestArray = sortedFiles[headEntry._arrayId];

                var smallestArrayHead = headMap[headEntry._arrayId];

                if (smallestArrayHead < smallestArray.Count)
                {
                    // add the next entry of smallest array into heap
                    minHeap.Insert(new ArrayEntry(headEntry._arrayId, smallestArray[smallestArrayHead]));

                    headMap[smallestArrayHead] = headMap[smallestArrayHead] + 1;
                }
            }

            return result;
        }  
    }

    internal class ArrayEntry : IComparable
    {
        public readonly int _arrayId;
        public readonly int _value;

        public ArrayEntry(int arrayId, int value)
        {
            _arrayId = arrayId;
            _value = value;
        }

        public int CompareTo(ArrayEntry other)
        {
            return _value.CompareTo(other._value);
        }

        public int CompareTo(object obj)
        {
            return CompareTo(obj as ArrayEntry);
        }
    }
}