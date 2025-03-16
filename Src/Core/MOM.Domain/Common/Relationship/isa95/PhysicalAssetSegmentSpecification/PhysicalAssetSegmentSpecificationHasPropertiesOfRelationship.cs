namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty>, IEquatable<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship>
    {
        public PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship? left, PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship? left, PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}