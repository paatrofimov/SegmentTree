using System;

// https://visualgo.net/en/segmenttree

// https://e-maxx.ru/algo/segment_tree

namespace SegmentTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = new[] {1L, 6, -6, 2, -4, 5, 3, 8, 17, 4};

            //var tree = SegmentTreeBuilder.BuildSegmentTree(arr, SegmentTreeNodeDataBuilders.Sum, SegmentTreeLeafDataBuilders.Value);
            //SegmentTreeStupidPrinter.PrintTree(tree);

            //var sumOfRange = GetSumOfRangeRequest.GetSumOfRange(tree, arr.Length, 1, 5);
            //Console.WriteLine(sumOfRange);

            //ModifyValueRequest.Modify(tree, arr.Length, 1, 5, SegmentTreeNodeDataBuilders.Sum);
            //SegmentTreeStupidPrinter.PrintTree(tree);

            //var tree = SegmentTreeBuilder.BuildSegmentTree(arr, SegmentTreeNodeDataBuilders.Min, SegmentTreeLeafDataBuilders.Value);
            //var minOfRange = GetMinOfRangeRequest.GetMinOfRange(tree, arr.Length, 6, 9);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //Console.WriteLine(minOfRange);

            //var arrPrefixWithSum = GetArrayPrefixEndIndexWithSumRequest.GetArrayPrefixEndIndexWithSum(tree, arr.Length, 20);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //Console.WriteLine(arrPrefixWithSum);

            //var tree = SegmentTreeBuilder.BuildSegmentTree(
            //    arr,
            //    SegmentTreeNodeDataBuilders.BuildNodeDataForMaxSumOfSubSegment,
            //    SegmentTreeLeafDataBuilders.BuildNodeDataForMaxSumOfSubSegment);
            //var subSegmentWithMaxSum = GetSubSegmentWithMaxSumRequest.GetSubSegmentWithMaxSum(tree, arr.Length, 3, 6);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //Console.WriteLine(subSegmentWithMaxSum);

            // https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
            //var arr = Enumerable.Repeat(0L, 10).ToArray();
            //var abks = new[]
            //           {
            //               new[] {1, 5, 3},
            //               new[] {4, 8, 7},
            //               new[] {6, 9, 1}
            //           };
            //var arr = Enumerable.Repeat(0L, 5).ToArray();
            //var abks = new[]
            //           {
            //               new[] {1, 2, 100},
            //               new[] {2, 5, 100},
            //               new[] {3, 4, 100}
            //           };
            //var n = 4;
            //var abks = new[]
            //           {
            //               new[] {2, 3, 603},
            //               new[] {1, 1, 286},
            //               new[] {4, 4, 882}
            //           };
            //var n = 4000;
            //var abks = File.ReadAllLines("D:\\1.txt").Select(line => line.Split(' ').Select(int.Parse).ToArray())
            //               .ToArray();
            //var tree = SegmentTreeBuilder.BuildSegmentTree(0L,
            //                                               n,
            //                                               SegmentTreeNodeDataBuilders.ConstantValue(0L),
            //                                               SegmentTreeLeafDataBuilders.Value);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //foreach (var abk in abks)
            //{
            //    Console.WriteLine(string.Join(",", abk.Select(i => i.ToString())));
            //    ModifyRangeRequest.Modify(tree,
            //                              n,
            //                              abk[0] - 1,
            //                              abk[1] - 1,
            //                              i => i + abk[2]);
            //}
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //Console.WriteLine(GetSubSegmentsSumValueRequest.Get(tree, n));

            //var tree = SegmentTreeBuilder.BuildSegmentTree(arr,
            //                                               SegmentTreeNodeDataBuilders.ConstantValue(-1L),
            //                                               SegmentTreeLeafDataBuilders.Value);
            //AssignRangeRequest.Assign(tree, arr.Length, 0, 9, 8);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //AssignRangeRequest.Assign(tree, arr.Length, 8, 9, 5);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //AssignRangeRequest.Assign(tree, arr.Length, 1, 3, 7);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //AssignRangeRequest.Assign(tree, arr.Length, 4, 7, 3);
            //SegmentTreeStupidPrinter.PrintTree(tree);
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 0));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 1));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 3));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 4));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 6));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 7));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 8));
            //Console.WriteLine(GetPosRequest.Get(tree, arr.Length, 9));

            Console.ReadLine();
        }
    }
}