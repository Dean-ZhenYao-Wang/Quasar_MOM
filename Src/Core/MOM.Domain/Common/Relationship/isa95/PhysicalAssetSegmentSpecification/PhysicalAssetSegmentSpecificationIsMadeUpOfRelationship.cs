namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification>, IEquatable<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship>
    {
        public PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship? left, PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship? left, PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}