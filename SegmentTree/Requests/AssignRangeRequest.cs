using System;

namespace SegmentTree.Requests
{
    public static class AssignRangeRequest
    {
        public static void Assign(long[] tree, int n, long l, long r, long value)
        {
            AssignInternal(tree, 0, n - 1, l, r, 1, value);
        }

        private static void AssignInternal(long[] tree,
                                           int segmentStart,
                                           int segmentEnd,
                                           long subSegmentL,
                                           long subSegmentR,
                                           int segmentParent,
                                           long color)
        {
            if (subSegmentL > subSegmentR)
            {
                return;
            }

            if (segmentStart == subSegmentL && segmentEnd == subSegmentR)
            {
                tree[segmentParent] = color;
                //SegmentTreeStupidPrinter.PrintTree(tree);
                return;
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            if (tree[segmentParent] != -1)
            {
                tree[segmentParent * 2] = tree[segmentParent];
                tree[segmentParent * 2 + 1] = tree[segmentParent];
                tree[segmentParent] = -1;
            }

            AssignInternal(tree,
                           segmentStart,
                           segmentMiddle,
                           subSegmentL,
                           Math.Min(segmentMiddle, subSegmentR),
                           segmentParent * 2,
                           color);


            AssignInternal(tree,
                           segmentMiddle + 1,
                           segmentEnd,
                           Math.Max(segmentMiddle + 1, subSegmentL),
                           subSegmentR,
                           segmentParent * 2 + 1,
                           color);
        }
    }
}