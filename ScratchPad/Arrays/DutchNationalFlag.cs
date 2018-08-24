using System;
namespace ScratchPad.Arrays
{
    public class DutchNationalFlag
    {
        #region
        //[Benchmark]
        public void Arrange(int[] arr, int pivot){

            // first-pass
            for (var i = 0; i < arr.Length; i++){
                for (var j = i + 1; j < arr.Length; j++){
                    if(arr[j] < pivot){
                        Swap(arr, i, j);
                        break;
                    }
                }
            }

            // second-pass
            for (var i = arr.Length - 1; i >= 0; i--){
                for (var j = i - 1; j >= 0 && arr[j] >= pivot; j--){
                    if(arr[j] > pivot){
                        Swap(arr, i, j);
                        break;
                    }
                }
            }
        }
        #endregion

        public void Arrange1(int[] arr, int pivot)
        {

            // first-pass
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < pivot)
                    {
                        Swap(arr, i, j);
                        break;
                    }
                }
            }

            // second-pass
            for (var i = arr.Length - 1; arr[i] >= pivot && i >= 0; i--)
            {
                for (var j = i - 1; j >= 0 && arr[j] >= pivot; j--)
                {
                    if (arr[j] > pivot)
                    {
                        Swap(arr, i, j);
                        break;
                    }
                }
            }
        }

        public void Arrange2(int[] arr, int pivot)
        {
            var small = 0;
            // first-pass
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(arr, i, small++);
                    //break;
                }
            }

            var large = arr.Length - 1;
            // second-pass
            for (var i = arr.Length - 1; arr[i] >= pivot && i >= 0; i--)
            {
                if (arr[i] > pivot)
                {
                    Swap(arr, i, large--);
                    //break;
                }
            }
        }

        void Swap(int[] arr, int s, int d)
        {
            var temp = arr[s];
            arr[s] = arr[d];
            arr[d] = temp;
        }
    }
}
