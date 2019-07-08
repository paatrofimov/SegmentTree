namespace SegmentTree.Requests
{
    public static class GetArrayPrefixEndIndexWithSumRequest
    {
        public static int GetArrayPrefixEndIndexWithSum(int[] tree, int n, int sum)
        {
            return GetArrayPrefixEndIndexWithSumRequestInternal(tree, 0, n - 1, sum, 1);
        }

        private static int GetArrayPrefixEndIndexWithSumRequestInternal(int[] tree,
                                                                        int segmentStart,
                                                                        int segmentEnd,
                                                                        int sum,
                                                                        int segmentParent)
        {
            if (segmentStart == segmentEnd)
            {
                return segmentStart;
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;
            if (tree[segmentParent * 2] >= sum)
            {
                return GetArrayPrefixEndIndexWithSumRequestInternal(tree,
                                                                    segmentStart,
                                                                    segmentMiddle,
                                                                    sum,
                                                                    segmentParent * 2);
            }

            return GetArrayPrefixEndIndexWithSumRequestInternal(tree,
                                                                segmentMiddle + 1,
                                                                segmentEnd,
                                                                sum - tree[segmentParent * 2],
                                                                segmentParent * 2 + 1);
        }
    }
}