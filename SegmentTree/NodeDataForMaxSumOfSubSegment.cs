using System;

namespace SegmentTree
{
    public class NodeDataForMaxSumOfSubSegment : IEquatable<NodeDataForMaxSumOfSubSegment>
    {
        public int Sum { get; set; }
        public int Pref { get; set; }
        public int Suff { get; set; }
        public int Ans { get; set; }

        public override string ToString()
        {
            return $"{Pref}-{Sum}-{Suff}-{Ans}";
        }

        #region auto generated equality members

        public bool Equals(NodeDataForMaxSumOfSubSegment other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Sum == other.Sum && Pref == other.Pref && Suff == other.Suff && Ans == other.Ans;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((NodeDataForMaxSumOfSubSegment) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Sum;
                hashCode = (hashCode * 397) ^ Pref;
                hashCode = (hashCode * 397) ^ Suff;
                hashCode = (hashCode * 397) ^ Ans;
                return hashCode;
            }
        }

        #endregion
    }
}