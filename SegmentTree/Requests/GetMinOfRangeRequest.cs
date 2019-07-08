using System;

namespace SegmentTree.Requests
{
    public static class GetMinOfRangeRequest
    {
        public static int GetMinOfRange(int[] tree, int n, int l, int r)
        {
            return GetMinOfRangeInternal(tree, 0, n - 1, l, r, 1);
        }

        private static int GetMinOfRangeInternal(int[] tree,
                                                 int segmentStart,
                                                 int segmentEnd,
                                                 int segmentL,
                                                 int segmentR,
                                                 int segmentParent)
        {
            if (segmentL > segmentR)
            {
                return int.MaxValue;
            }

            if (segmentStart == segmentEnd)
            {
                return tree[segmentParent];
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;
            return Math.Min(
                GetMinOfRangeInternal(tree,
                                      segmentStart,
                                      segmentMiddle,
                                      segmentL,
                                      Math.Min(segmentR, segmentMiddle),
                                      segmentParent * 2),
                GetMinOfRangeInternal(tree,
                                      segmentMiddle + 1,
                                      segmentEnd,
                                      Math.Max(segmentL, segmentMiddle + 1),
                                      segmentR,
                                      segmentParent * 2 + 1)
            );
        }
    }
}