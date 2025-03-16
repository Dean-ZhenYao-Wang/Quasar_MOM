namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentParameter
{
    public class ProcessSegmentParameterContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>, IEquatable<ProcessSegmentParameterContainsRelationship>
    {
        public ProcessSegmentParameterContainsRelationship()
        {
            Name = "contains";
        }

        public ProcessSegmentParameterContainsRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentParameterContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentParameterContainsRelationship);
        }

        public bool Equals(ProcessSegmentParameterContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentParameterContainsRelationship? left, ProcessSegmentParameterContainsRelationship? right)
        {
            return EqualityComparer<ProcessSegmentParameterContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentParameterContainsRelationship? left, ProcessSegmentParameterContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentParameterContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}