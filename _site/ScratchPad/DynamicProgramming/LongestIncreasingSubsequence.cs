using System.Collections.Generic;
using System.Linq;

namespace ScratchPad.DynamicProgramming
{
    public static class LongestIncreasingSubsequence
    {
        static int _maxLisLength = 0;

        public static int LisHelper(int[] arr, int n)
        {
            if (n == 1)
            {
                return 1;
            }

            var _currentLisLength = 1;

            for (var i = 0; i < n-1; i++)
            {
                var subLength = LisHelper(arr, i);

                if (arr[n - 1] > arr[i] && (subLength + 1) > _currentLisLength)
                    _currentLisLength = subLength + 1;
            }

            if (_currentLisLength > _maxLisLength)
            {
                _maxLisLength = _currentLisLength;
            }
            return _currentLisLength;
        }

        public static int LISRecursive(int[] arr)
        {
            _maxLisLength = 1;

            LisHelper(arr, arr.Length);

            return _maxLisLength;
        }

        public static int LIS_DP(int[] arr)
        {
            return LIS_DP_Helper(arr, arr.Length);
        }

        private static int LIS_DP_Helper(IReadOnlyList<int> arr, int length)
        {
            int[] lisMap = new int[length];

            // initialize
            for (var i = 0; i < length; i++)
            {
                lisMap[i] = 1;
            }

            // iterate outer and then inner
            for(var outer = 1; outer < length; outer++)
                for (var inner = 0; inner < outer; inner++)
                {
                    if (arr[inner] < arr[outer] && lisMap[inner] + 1 > lisMap[outer])
                    {
                        lisMap[outer] = lisMap[inner] + 1;
                    }
                }

            return lisMap.Max();
        }
    }
}