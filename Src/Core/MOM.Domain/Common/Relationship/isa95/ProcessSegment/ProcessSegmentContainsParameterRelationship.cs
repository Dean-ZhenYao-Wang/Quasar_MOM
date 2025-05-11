namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsParameterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>, IEquatable<ProcessSegmentContainsParameterRelationship>
    {
        public ProcessSegmentContainsParameterRelationship()
        {
            Name = "containsParameter";
        }

        public ProcessSegmentContainsParameterRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentContainsParameterRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentContainsParameterRelationship);
        }

        public bool Equals(ProcessSegmentContainsParameterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentContainsParameterRelationship? left, ProcessSegmentContainsParameterRelationship? right)
        {
            return EqualityComparer<ProcessSegmentContainsParameterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentContainsParameterRelationship? left, ProcessSegmentContainsParameterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentContainsParameterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}