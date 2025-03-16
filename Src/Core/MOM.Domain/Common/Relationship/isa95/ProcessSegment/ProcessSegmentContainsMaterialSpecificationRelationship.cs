namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsMaterialSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification>, IEquatable<ProcessSegmentContainsMaterialSpecificationRelationship>
    {
        public ProcessSegmentContainsMaterialSpecificationRelationship()
        {
            Name = "containsMaterialSpecification";
        }

        public ProcessSegmentContainsMaterialSpecificationRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentContainsMaterialSpecificationRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentContainsMaterialSpecificationRelationship);
        }

        public bool Equals(ProcessSegmentContainsMaterialSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentContainsMaterialSpecificationRelationship? left, ProcessSegmentContainsMaterialSpecificationRelationship? right)
        {
            return EqualityComparer<ProcessSegmentContainsMaterialSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentContainsMaterialSpecificationRelationship? left, ProcessSegmentContainsMaterialSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentContainsMaterialSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}