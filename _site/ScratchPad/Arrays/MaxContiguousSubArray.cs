using System;

namespace ScratchPad.Arrays
{
    public class MaxContiguousSubArray
    {
        public static void FindMax(int[] arr)
        {
            int tstart = 0, start = 0, end = 0;
            int currSum = arr[0],  maxSum = arr[0];

            for(var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i] + currSum)
                {
                    tstart = i;
                    currSum = arr[i];
                }
                else
                {
                    currSum = arr[i] + currSum;
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    end = i;
                    start = tstart;
                }
            }
            Console.WriteLine("Max Sum : {0}, start: {1}, end: {2}", maxSum, start, end);
        } 
    }
}