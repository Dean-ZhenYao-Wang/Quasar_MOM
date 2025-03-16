namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecificationProperty
{
    public class PhysicalAssetSegmentSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty>, IEquatable<PhysicalAssetSegmentSpecificationPropertyContainsRelationship>
    {
        public PhysicalAssetSegmentSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PhysicalAssetSegmentSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSegmentSpecificationPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationPropertyContainsRelationship);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationPropertyContainsRelationship? left, PhysicalAssetSegmentSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationPropertyContainsRelationship? left, PhysicalAssetSegmentSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSegmentSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}