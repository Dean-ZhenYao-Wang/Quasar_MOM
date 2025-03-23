namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship>
    {
        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship()
        {
            Name = "correspondsToPhysicalAsset";
        }

        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}