namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentIsMadeUpOfRelationship>
    {
        public OperationsSegmentIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public OperationsSegmentIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentIsMadeUpOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentIsMadeUpOfRelationship);
        }

        public bool Equals(OperationsSegmentIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentIsMadeUpOfRelationship? left, OperationsSegmentIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationsSegmentIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentIsMadeUpOfRelationship? left, OperationsSegmentIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}