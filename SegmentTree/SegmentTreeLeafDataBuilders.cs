using System;

namespace SegmentTree
{
    public static class SegmentTreeLeafDataBuilders
    {
        public static T Value<T>(T arrItem)
        {
            return arrItem;
        }

        public static NodeDataForMaxSumOfSubSegment BuildNodeDataForMaxSumOfSubSegment(int arrItem)
        {
            var result = new NodeDataForMaxSumOfSubSegment()
                         {
                             Sum = arrItem,
                             Pref =  arrItem,
                             Suff =  arrItem,
                             Ans = arrItem,
                         };

            Console.WriteLine($"Building leaf: {result}");

            return result;
        }
    }
}