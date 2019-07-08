using System;
using System.Linq;

namespace SegmentTree
{
    public class TreeHelpers
    {
        public static int GetLevelsCount(int n)
        {
            return (int) Math.Ceiling(Math.Log(n, 2));
        }

        public static int GetLevelSize(int level)
        {
            return (int) Math.Pow(2, level);
        }

        public static int GetLevelStartInd(int level)
        {
            return (int) Math.Pow(2, level);
        }

        public static T[] GetLevelItems<T>(SegmentTree<T> tree,
                                           int level)
        {
            var levelSize = GetLevelSize(level);
            return tree.Value.Values
                       .Skip(levelSize)
                       .Take(levelSize)
                       .Where(i => !i.Equals(tree.DefaultValue))
                       .ToArray();
        }

        public static T[] GetLastLevelItems<T>(SegmentTree<T> tree, int n)
        {
            var levelsCount = GetLevelsCount(n);
            return GetLevelItems(tree, levelsCount);
        }
    }
}