namespace SegmentTree.Requests
{
    public static class GetPosRequest
    {
        public static long Get(long[] tree, int n, long pos)
        {
            return GetInternal(tree, 0, n - 1, 1, pos);
        }

        private static long GetInternal(long[] tree,
                                        int segmentStart,
                                        int segmentEnd,
                                        int segmentParent,
                                        long pos)
        {
            if (segmentStart == segmentEnd ||
                segmentStart <= pos && pos <= segmentEnd && tree[segmentParent] != -1)
            {
                return tree[segmentParent];
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            return pos <= segmentMiddle
                       ? GetInternal(tree, segmentStart, segmentMiddle, segmentParent * 2, pos)
                       : GetInternal(tree, segmentMiddle + 1, segmentEnd, segmentParent * 2 + 1, pos);
        }
    }
}