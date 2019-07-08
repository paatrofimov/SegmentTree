using System;

namespace SegmentTree
{
    public class SegmentTreeStupidPrinter
    {
        public static void PrintTree<T>(T[] tree, Func<T, string> toString = null)
        {
            var lastFloor = 0;
            for (int i = 1; i < tree.Length; i++)
            {
                var floor = (int) Math.Floor(Math.Log(i, 2));
                if (floor > lastFloor)
                {
                    lastFloor = floor;
                    Console.WriteLine();
                }

                Console.Write(" {0} ", toString?.Invoke(tree[i]) ?? tree[i]?.ToString() ?? "-");
            }

            Console.WriteLine();
        }
    }
}