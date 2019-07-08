namespace SegmentTree.Requests
{
    public static class GetSubSegmentWithMaxSumRequest
    {
        public static NodeDataForMaxSumOfSubSegment GetSubSegmentWithMaxSum(
            SegmentTree<NodeDataForMaxSumOfSubSegment> tree, int n, int l, int r)
        {
            return GetSubSegmentWithMaxSumRequestInternal(tree, 0, n - 1, l, r, 1);
        }

        private static NodeDataForMaxSumOfSubSegment GetSubSegmentWithMaxSumRequestInternal(
            SegmentTree<NodeDataForMaxSumOfSubSegment> tree,
            int segmentStart,
            int segmentEnd,
            int subSegmentL,
            int subSegmentR,
            int segmentParent)
        {
            if (segmentStart == subSegmentL && segmentEnd == subSegmentR)
            {
                return tree.Value[segmentParent];
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;
            if (subSegmentR <= segmentMiddle)
            {
                return GetSubSegmentWithMaxSumRequestInternal(tree,
                                                              segmentStart,
                                                              segmentMiddle,
                                                              subSegmentL,
                                                              subSegmentR,
                                                              segmentParent * 2);
            }

            if (subSegmentL > segmentMiddle)
            {
                return GetSubSegmentWithMaxSumRequestInternal(tree,
                                                              segmentMiddle + 1,
                                                              segmentEnd,
                                                              subSegmentL,
                                                              subSegmentR,
                                                              segmentParent * 2 + 1);
            }

            return SegmentTreeNodeDataBuilders.BuildNodeDataForMaxSumOfSubSegment(
                GetSubSegmentWithMaxSumRequestInternal(tree,
                                                       segmentStart,
                                                       segmentMiddle,
                                                       subSegmentL,
                                                       segmentMiddle,
                                                       segmentParent * 2),
                GetSubSegmentWithMaxSumRequestInternal(tree,
                                                       segmentMiddle + 1,
                                                       segmentEnd,
                                                       segmentMiddle + 1,
                                                       subSegmentR,
                                                       segmentParent * 2 + 1)
            );
        }
    }
}