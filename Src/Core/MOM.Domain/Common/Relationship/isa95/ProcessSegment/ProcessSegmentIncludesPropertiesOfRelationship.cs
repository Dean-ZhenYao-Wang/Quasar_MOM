namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentIncludesPropertiesOfRelationship>
    {
        public ProcessSegmentIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public ProcessSegmentIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentIncludesPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentIncludesPropertiesOfRelationship);
        }

        public bool Equals(ProcessSegmentIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentIncludesPropertiesOfRelationship? left, ProcessSegmentIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<ProcessSegmentIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentIncludesPropertiesOfRelationship? left, ProcessSegmentIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}