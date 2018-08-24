using System;

namespace ScratchPadTests.Sorting
{
    public class BubbleSort<T> where T : IComparable
    {
        public static T[] Sort(T[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var modified = false;

                for (var j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1]) > 0)
                    {
                        Swap(arr,j, j+1);
                        modified = true;
                    }
                }

                if (!modified)
                {
                    break;
                }
            }
            return arr;
        }

        public static void Swap(T[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        } 
    }
}