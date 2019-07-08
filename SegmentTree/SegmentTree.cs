using System;
using System.Collections.Generic;

namespace SegmentTree
{
    public class SegmentTree<T>
    {
        public T DefaultValue { get; set; }
        public Dictionary<int, T> Value { get; set; }
        public Func<T, T, T> BuildNodeData { get; set; }
    }
}