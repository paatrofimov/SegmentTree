using System;

namespace SegmentTree.Requests
{
    public static class GetSubSegmentsSumValueRequest
    {
        public static long Get(long[] tree, int n)
        {
            var max = 0L;
            GetInternal(tree, 0, n - 1, 1, tree[1], ref max);
            return max;
        }

        private static void GetInternal(long[] tree,
                                        int segmentStart,
                                        int segmentEnd,
                                        int segmentParent,
                                        long currentSum,
                                        ref long max)
        {
            if (segmentStart > segmentEnd)
            {
                return;
            }

            if (segmentStart == segmentEnd)
            {
                max = Math.Max(max, currentSum + tree[segmentParent]);
                return;
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            GetInternal(tree,
                        segmentStart,
                        segmentMiddle,
                        segmentParent * 2,
                        tree[segmentParent] + currentSum,
                        ref max);
            GetInternal(tree,
                        segmentMiddle + 1,
                        segmentEnd,
                        segmentParent * 2 + 1,
                        tree[segmentParent] + currentSum,
                        ref max);
        }
    }
}