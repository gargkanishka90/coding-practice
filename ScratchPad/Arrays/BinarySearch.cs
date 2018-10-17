using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ScratchPad.Arrays
{
    public class BinarySearch
    {
        public int FindIndex(int[] arr, int target){
            if (arr == null || arr.Length == 0)
                return -1;

            var start = 0;
            var end = arr.Length - 1;

            while(start <= end){
                var mid = start + (end - start) / 2;
                if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                    return mid;
            }

            return -1;
        }

        public int FindInsertIndex(int[] sortedArray, int target)
        {
            if (sortedArray.Length == 0)
                return 0;

            if (target <= sortedArray[0])
                return 0;

            if (target > sortedArray[sortedArray.Length - 1])
                return sortedArray.Length;

            var start = 0;
            var end = sortedArray.Length - 1;

            while (start <= end)
            {
                if (start == end)
                    return start;

                var mid = start + (end - start) / 2;
                if (sortedArray[mid] == target)
                {
                    return mid;
                }

                if (sortedArray[mid] < target)
                {
                    start = mid + 1;
                }
                else
                    end = mid;
            }

            return -1;
        }

        // Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        // You may assume no duplicates in the array.
        public int SearchInsert_BinarySearch_Method1(int[] sortedArray, int target)
        {
            if (sortedArray == null)
                return -1;

            if (sortedArray.Length == 0)
                return 0;

            if (target > sortedArray[sortedArray.Length - 1])
                return sortedArray.Length;

            if (target < sortedArray[0])
                return 0;

            var start = 0;
            var end = sortedArray.Length;

            while (start < end)
            {
                var mid = start + (end - start) / 2;

                if (target > sortedArray[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return start;
        }

        public int SearchInsert_BinarySearch_Method2(int[] sortedArray, int target)
        {
            if (sortedArray == null)
                return -1;

            if (sortedArray.Length == 0)
                return 0;

            if (target > sortedArray[sortedArray.Length - 1])
                return sortedArray.Length;

            if (target < sortedArray[0])
                return 0;

            var start = 0;
            var end = sortedArray.Length - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (target > sortedArray[mid])
                {
                    start = mid + 1;
                }
                else if (target < sortedArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return start;
        }
    }
}
