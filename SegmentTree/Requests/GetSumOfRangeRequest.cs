using System;

namespace SegmentTree.Requests
{
    public static class GetSumOfRangeRequest
    {
        public static int GetSumOfRange(int[] tree, int n, int leftInd, int rightInd)
        {
            return GetSumOfRangeInternal(tree, 0, n - 1, leftInd, rightInd, 1);
        }

        private static int GetSumOfRangeInternal(int[] tree,
                                                 int segmentStart,
                                                 int segmentEnd,
                                                 int segmentL,
                                                 int segmentR,
                                                 int segmentParent)
        {
            if (segmentL > segmentR)
                return 0;

            if (segmentStart == segmentL && segmentEnd == segmentR)
            {
                return tree[segmentParent];
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;
            return GetSumOfRangeInternal(tree,
                                         segmentStart,
                                         segmentMiddle,
                                         segmentL,
                                         Math.Min(segmentR, segmentMiddle),
                                         2 * segmentParent) +
                   GetSumOfRangeInternal(tree,
                                         segmentMiddle + 1,
                                         segmentEnd,
                                         Math.Max(segmentL, segmentMiddle + 1),
                                         segmentR,
                                         2 * segmentParent + 1);
        }
    }
}