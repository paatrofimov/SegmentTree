using System;

namespace SegmentTree
{
    public class SegmentTreeBuilder
    {
        public static T[] BuildSegmentTree<T>(T[] arr,
                                              Func<T, T, T> buildNodeData,
                                              Func<T, T> buildLeafData)
        {
            var tree = new T[arr.Length * 4];
            BuildSegmentTreeInternal(buildNodeData, arrInd => buildLeafData(arr[arrInd]), tree, 1, 0, arr.Length - 1);
            return tree;
        }

        public static TD[] BuildSegmentTree2<T, TD>(T[] arr,
                                                    Func<TD, TD, TD> buildNodeData,
                                                    Func<T, TD> buildLeafData)
        {
            var tree = new TD[arr.Length * 4];
            BuildSegmentTreeInternal2(buildNodeData, arrInd => buildLeafData(arr[arrInd]), tree, 1, 0, arr.Length - 1);
            return tree;
        }

        public static T[] BuildSegmentTree<T>(T arrItem,
                                              int n,
                                              Func<T, T, T> buildNodeData,
                                              Func<T, T> buildLeafData)
        {
            var tree = new T[n * 4];
            BuildSegmentTreeInternal(buildNodeData, _ => buildLeafData(arrItem), tree, 1, 0, n - 1);
            return tree;
        }

        private static void BuildSegmentTreeInternal<T>(Func<T, T, T> buildNodeData,
                                                        Func<int, T> buildLeafData,
                                                        T[] tree,
                                                        int currentInd,
                                                        int leftInd,
                                                        int rightInd)
        {
            if (leftInd == rightInd)
            {
                tree[currentInd] = buildLeafData(leftInd);
            }
            else
            {
                var middleInd = (rightInd + leftInd) / 2;
                BuildSegmentTreeInternal(buildNodeData, buildLeafData, tree, 2 * currentInd, leftInd,
                                         middleInd);
                BuildSegmentTreeInternal(buildNodeData, buildLeafData, tree, 2 * currentInd + 1,
                                         middleInd + 1,
                                         rightInd);
                tree[currentInd] = buildNodeData(tree[2 * currentInd], tree[2 * currentInd + 1]);
            }
        }

        private static void BuildSegmentTreeInternal2<TD>(Func<TD, TD, TD> buildNodeData,
                                                          Func<int, TD> buildLeafData,
                                                          TD[] tree,
                                                          int currentInd,
                                                          int leftInd,
                                                          int rightInd)
        {
            if (leftInd == rightInd)
            {
                tree[currentInd] = buildLeafData(leftInd);
            }
            else
            {
                var middleInd = (rightInd + leftInd) / 2;
                BuildSegmentTreeInternal2(buildNodeData, buildLeafData, tree, 2 * currentInd, leftInd,
                                          middleInd);
                BuildSegmentTreeInternal2(buildNodeData, buildLeafData, tree, 2 * currentInd + 1,
                                          middleInd + 1,
                                          rightInd);
                tree[currentInd] = buildNodeData(tree[2 * currentInd], tree[2 * currentInd + 1]);
            }
        }
    }
}