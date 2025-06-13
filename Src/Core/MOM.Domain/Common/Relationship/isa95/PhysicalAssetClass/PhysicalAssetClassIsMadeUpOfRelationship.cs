namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassIsMadeUpOfRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetClassIsMadeUpOfRelationship>
    {
        public PhysicalAssetClassIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetClassIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetClassIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetClassIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetClassIsMadeUpOfRelationship? left, PhysicalAssetClassIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetClassIsMadeUpOfRelationship? left, PhysicalAssetClassIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetClassIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}