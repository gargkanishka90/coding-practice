using System;
using System.Collections.Concurrent;

namespace ScratchPadTests.Sorting
{
    public class QuickSort<T> where T : IComparable
    {
        public static T[] Sort(T[] arr, int low, int high)
        {
            if (low < high)
            {
                var pi = Partitioner(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
            return arr;
        }

        public static int Partitioner(T[] arr, int low, int high)
        {
            var pivot = arr[high];

            var i = low - 1;

            for (var j = low; j < high; j++)
            {
                if (arr[j].CompareTo(pivot) < 0 || Equals(arr[j], pivot))
                {
                    i++;
                    Swap(arr, i , j);
                }
            }
            Swap(arr, i + 1 , high);
            return (i + 1);
        }

        public static void Swap(T[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}