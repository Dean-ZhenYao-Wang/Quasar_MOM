namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship>
    {
        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship()
        {
            Name = "correspondsToPhysicalAssetClass";
        }

        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}