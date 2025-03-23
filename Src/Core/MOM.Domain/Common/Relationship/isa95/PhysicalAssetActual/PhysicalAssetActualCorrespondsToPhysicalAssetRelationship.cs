namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualCorrespondsToPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship>
    {
        public PhysicalAssetActualCorrespondsToPhysicalAssetRelationship()
        {
            Name = "correspondsToPhysicalAsset";
        }

        public PhysicalAssetActualCorrespondsToPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualCorrespondsToPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualCorrespondsToPhysicalAssetRelationship);
        }

        public bool Equals(PhysicalAssetActualCorrespondsToPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetActualCorrespondsToPhysicalAssetRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetActualCorrespondsToPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualCorrespondsToPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}