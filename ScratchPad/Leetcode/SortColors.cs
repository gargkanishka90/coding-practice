namespace ScratchPadTests.Leetcode
{
    /* Question 75:
        Given an array with n objects colored red, white or blue, 
        sort them so that objects of the same color are adjacent, 
        with the colors in the order red, white and blue.

        Here, we will use the integers 0, 1, and 2 to represent the 
        color red, white, and blue respectively.
        
     */

    public class SortColors
    {
        public void Sort(int[] arr)
        {
            var low = 0;
            var high = arr.Length - 1;
            var mid = 0;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        Swap(arr, low, mid);
                        low++;
                        mid++;
                        break;

                    case 1:
                        mid++;
                        break;

                    case 2:
                        Swap(arr, mid, high);
                        high--;
                        break;
                }
            }
        }

        private static void Swap(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}