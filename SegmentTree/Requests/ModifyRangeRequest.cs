using System;

namespace SegmentTree.Requests
{
    public static class ModifyRangeRequest
    {
        public static void Modify<T>(T[] tree, int n, long l, long r, Func<T, T> modify)
        {
            ModifyInternal(tree, 0, n - 1, l, r, modify, 1);
        }

        private static void ModifyInternal<T>(T[] tree,
                                              int segmentStart,
                                              int segmentEnd,
                                              long subSegmentL,
                                              long subSegmentR,
                                              Func<T, T> modify,
                                              int segmentParent)
        {
            if (subSegmentL > subSegmentR || tree.Length <= segmentParent)
            {
                return;
            }

            if (segmentStart == subSegmentL && segmentEnd == subSegmentR)
            {
                tree[segmentParent] = modify(tree[segmentParent]);
                SegmentTreeStupidPrinter.PrintTree(tree);
                return;
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            ModifyInternal(tree,
                           segmentStart,
                           segmentMiddle,
                           subSegmentL,
                           Math.Min(segmentMiddle, subSegmentR),
                           modify,
                           segmentParent * 2);
            ModifyInternal(tree,
                           segmentMiddle + 1,
                           segmentEnd,
                           Math.Max(segmentMiddle + 1, subSegmentL),
                           subSegmentR,
                           modify,
                           segmentParent * 2 + 1);
        }
    }
}