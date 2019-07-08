using System;

namespace SegmentTree.Requests
{
    public static class ModifyValueRequest
    {
        public static void Modify<T>(T[] tree, int n, int pos, T value, Func<T, T, T> buildNodeData)
        {
            ModifyInternal(tree, 0, n - 1, pos, value, 1, buildNodeData);
        }

        private static void ModifyInternal<T>(T[] tree, int segmentStart, int segmentEnd, int pos, T value,
                                              int segmentParent, Func<T, T, T> buildNodeData)
        {
            if (segmentStart == segmentEnd)
            {
                tree[segmentParent] = value;
                return;
            }

            var segmentMiddle = (segmentStart + segmentEnd) / 2;

            if (pos <= segmentMiddle)
            {
                ModifyInternal(tree, segmentStart, segmentMiddle, pos, value, segmentParent * 2, buildNodeData);
            }
            else
            {
                ModifyInternal(tree, segmentMiddle + 1, segmentEnd, pos, value, segmentParent * 2 + 1, buildNodeData);
            }

            tree[segmentParent] = buildNodeData(tree[segmentParent * 2], tree[segmentParent * 2 + 1]);
        }
    }
}