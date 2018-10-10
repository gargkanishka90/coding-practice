using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class NumArray
    {

        private readonly int[] _arr;
        private int[] _segArray = null;

        public NumArray(int[] nums)
        {
            _arr = nums;
            var numElements = _arr.Length;
            if (numElements > 0)
            {
                var segmentTreeSize = FindSegmentTreeSize(numElements);
                _segArray = new int[2 * segmentTreeSize - 1];
                ConstructSegTree(_segArray, _arr, 0, numElements - 1, 0);
            }
        }

        public void Update(int i, int val)
        {
            UpdateHelper(_arr, _segArray, 0, _arr.Length - 1, i, val);
        }

        private void UpdateHelper(int[] arr, int[] segArray, int s, int e, int i, int val)
        {
            if (s == e)
            {
                _arr[s] = val;
            }
            else
            {
                var mid = s + (e - s) / 2;
                if (i < mid)
                {
                    UpdateHelper(arr, segArray, s, mid, 2*i +1, val);
                }
                else
                {
                    UpdateHelper(arr,segArray, mid+1, e, 2*i + 2, val);
                }
            }

            _segArray[i] = _segArray[2 * i + 1] + _segArray[2 * i + 2];
        }

        public int SumRange(int i, int j)
        {
            return QuerySegmentTree(_segArray, 0, _arr.Length - 1, i, j, 0);
        }

        private int QuerySegmentTree(int[] segArray, int s, int e, int qs, int qe, int current)
        {
            if (CompleteOverlap(s, e, qs, qe))
            {
                return segArray[current];
            }

            if (NoOverlap(s, e, qs, qe))
            {
                return 0;
            }

            var mid = s + (e - s) / 2;

            // partial-overlap
            return QuerySegmentTree(segArray, s, mid, qs, qe, 2 * current + 1) +
                   QuerySegmentTree(segArray, mid + 1, e, qs, qe, 2 * current + 2);
        }

        private bool NoOverlap(int s, int e, int qs, int qe)
        {
            return qs > e || qe < s;
        }

        private bool CompleteOverlap(int s, int e, int qs, int qe)
        {
            return qs <= s && qe >= e;
        }

        public void ConstructSegTree(int[] segArray, int[] arr, int s, int e, int current)
        {
            if (s == e)
            {
                segArray[current] = arr[s];
            }
            else
            {
                var mid = s + (e - s) / 2;
                ConstructSegTree(segArray, arr, s, mid, 2 * current + 1);
                ConstructSegTree(segArray, arr, mid + 1, e, 2 * current + 2);
                segArray[current] = segArray[2 * current + 1] + segArray[current * 2 + 2];
            }
        }

        public int FindSegmentTreeSize(int n)
        {
            var seed = 1;
            for (; seed < n; seed <<= 1) ;

            return seed;
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * obj.Update(i,val);
     * int param_2 = obj.SumRange(i,j);
     */
}
