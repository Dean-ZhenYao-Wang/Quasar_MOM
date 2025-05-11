namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentIsMadeUpOfRelationship>
    {
        public EquipmentIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentIsMadeUpOfRelationship? left, EquipmentIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentIsMadeUpOfRelationship? left, EquipmentIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}