namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterCorrespondsToSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>, IEquatable<SegmentParameterCorrespondsToSpecificationRelationship>
    {
        public SegmentParameterCorrespondsToSpecificationRelationship()
        {
            Name = "correspondsToSpecification";
        }

        public SegmentParameterCorrespondsToSpecificationRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentParameterCorrespondsToSpecificationRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentParameterCorrespondsToSpecificationRelationship);
        }

        public bool Equals(SegmentParameterCorrespondsToSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentParameterCorrespondsToSpecificationRelationship? left, SegmentParameterCorrespondsToSpecificationRelationship? right)
        {
            return EqualityComparer<SegmentParameterCorrespondsToSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentParameterCorrespondsToSpecificationRelationship? left, SegmentParameterCorrespondsToSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentParameterCorrespondsToSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}