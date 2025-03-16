namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentIncludesPropertiesOfRelationship>
    {
        public OperationsSegmentIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public OperationsSegmentIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentIncludesPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentIncludesPropertiesOfRelationship);
        }

        public bool Equals(OperationsSegmentIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentIncludesPropertiesOfRelationship? left, OperationsSegmentIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationsSegmentIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentIncludesPropertiesOfRelationship? left, OperationsSegmentIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}