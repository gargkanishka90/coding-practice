using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.SegmentTree
{
    public class SegmentTree
    {
        public int FindSumRange(int[] arr, int l, int r)
        {
            var numElements = arr.Length;
            var segmentTreeSize = FindSegmentTreeSize(numElements);
            var segArray = new int[2*segmentTreeSize - 1];
            ConstructSegTree(segArray, arr, 0, numElements - 1, 0);
            return QuerySegmentTree(segArray, 0, arr.Length - 1, l, r, 0);
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
            var seed = 2;
            while (seed  < n)
            {
                seed = seed << 1;
            }

            return seed;
        }

        /*
         *
         * public class NumArray {
           
           public NumArray(int[] nums) {
           
           }
           
           public void Update(int i, int val) {
           
           }
           
           public int SumRange(int i, int j) {
           
           }
           }
         */
    }
}
