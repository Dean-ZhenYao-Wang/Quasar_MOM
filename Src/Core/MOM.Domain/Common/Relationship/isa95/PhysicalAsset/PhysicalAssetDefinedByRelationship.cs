namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetDefinedByRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetDefinedByRelationship>
    {
        public PhysicalAssetDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public PhysicalAssetDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetDefinedByRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetDefinedByRelationship);
        }

        public bool Equals(PhysicalAssetDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetDefinedByRelationship? left, PhysicalAssetDefinedByRelationship? right)
        {
            return EqualityComparer<PhysicalAssetDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetDefinedByRelationship? left, PhysicalAssetDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}