using System;
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
    }
}
