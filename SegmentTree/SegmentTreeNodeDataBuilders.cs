using System;

namespace SegmentTree
{
    public static class SegmentTreeNodeDataBuilders
    {
        public static Func<T, T, T> ConstantValue<T>(T value)
        {
            return (_, __) => value;
        }

        public static int Sum(int left, int right)
        {
            return left + right;
        }

        public static int Min(int left, int right)
        {
            return Math.Min(left, right);
        }

        public static NodeDataForMaxSumOfSubSegment BuildNodeDataForMaxSumOfSubSegment(
            NodeDataForMaxSumOfSubSegment left,
            NodeDataForMaxSumOfSubSegment right)
        {
            var result = new NodeDataForMaxSumOfSubSegment
                         {
                             Sum = left.Sum + right.Sum,
                             Pref = Math.Max(left.Pref, left.Sum + right.Pref),
                             Suff = Math.Max(right.Suff, right.Sum + left.Suff),
                             Ans = Math.Max(Math.Max(left.Ans, right.Ans), left.Suff + right.Pref)
                         };

            Console.WriteLine($"Building node: {left} & {right} -> {result}");

            return result;
        }
    }
}