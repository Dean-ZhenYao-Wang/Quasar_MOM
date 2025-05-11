namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsParameterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>, IEquatable<OperationsSegmentContainsParameterRelationship>
    {
        public OperationsSegmentContainsParameterRelationship()
        {
            Name = "containsParameter";
        }

        public OperationsSegmentContainsParameterRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentContainsParameterRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentContainsParameterRelationship);
        }

        public bool Equals(OperationsSegmentContainsParameterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentContainsParameterRelationship? left, OperationsSegmentContainsParameterRelationship? right)
        {
            return EqualityComparer<OperationsSegmentContainsParameterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentContainsParameterRelationship? left, OperationsSegmentContainsParameterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentContainsParameterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}