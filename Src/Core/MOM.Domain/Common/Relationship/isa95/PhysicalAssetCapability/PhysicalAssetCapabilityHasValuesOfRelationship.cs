namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty>, IEquatable<PhysicalAssetCapabilityHasValuesOfRelationship>
    {
        public PhysicalAssetCapabilityHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PhysicalAssetCapabilityHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityHasValuesOfRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityHasValuesOfRelationship? left, PhysicalAssetCapabilityHasValuesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityHasValuesOfRelationship? left, PhysicalAssetCapabilityHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}