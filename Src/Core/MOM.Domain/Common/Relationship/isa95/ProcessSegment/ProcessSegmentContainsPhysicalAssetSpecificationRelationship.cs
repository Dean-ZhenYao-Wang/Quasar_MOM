namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsPhysicalAssetSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification>, IEquatable<ProcessSegmentContainsPhysicalAssetSpecificationRelationship>
    {
        public ProcessSegmentContainsPhysicalAssetSpecificationRelationship()
        {
            Name = "containsPhysicalAssetSpecification";
        }

        public ProcessSegmentContainsPhysicalAssetSpecificationRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentContainsPhysicalAssetSpecificationRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentContainsPhysicalAssetSpecificationRelationship);
        }

        public bool Equals(ProcessSegmentContainsPhysicalAssetSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentContainsPhysicalAssetSpecificationRelationship? left, ProcessSegmentContainsPhysicalAssetSpecificationRelationship? right)
        {
            return EqualityComparer<ProcessSegmentContainsPhysicalAssetSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentContainsPhysicalAssetSpecificationRelationship? left, ProcessSegmentContainsPhysicalAssetSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentContainsPhysicalAssetSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}