using System;

namespace SegmentTree.Requests
{
    public static class GetSubSegmentsMaxValueRequest
    {
        public static int Get(SegmentTree<int> tree, int n)
        {
            return GetInternal(tree, 0, n - 1, 1);
        }

        private static int GetInternal(SegmentTree<int> tree,
                                       int segmentStart,
                                       int segmentEnd,
                                       int segmentParent)
        {
            if (segmentStart > segmentEnd)
            {
                return 0;
            }

            if (segmentStart == segmentEnd)
            {
                return tree.Value[segmentParent];
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            return Math.Max(GetInternal(tree,
                                        segmentStart,
                                        segmentMiddle,
                                        segmentParent * 2),
                            GetInternal(tree,
                                        segmentMiddle + 1,
                                        segmentEnd,
                                        segmentParent * 2 + 1));
        }
    }
}