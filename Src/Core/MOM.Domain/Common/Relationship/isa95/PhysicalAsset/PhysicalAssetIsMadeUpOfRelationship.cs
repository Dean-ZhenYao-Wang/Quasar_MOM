namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetIsMadeUpOfRelationship>
    {
        public PhysicalAssetIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetIsMadeUpOfRelationship? left, PhysicalAssetIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetIsMadeUpOfRelationship? left, PhysicalAssetIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}