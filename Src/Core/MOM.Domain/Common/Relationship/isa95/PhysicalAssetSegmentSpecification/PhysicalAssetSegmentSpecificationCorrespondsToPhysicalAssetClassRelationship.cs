namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship>
    {
        public PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship()
        {
            Name = "correspondsToPhysicalAssetClass";
        }

        public PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}