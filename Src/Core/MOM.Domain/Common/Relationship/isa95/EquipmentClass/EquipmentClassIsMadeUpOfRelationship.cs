namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentClassIsMadeUpOfRelationship>
    {
        public EquipmentClassIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentClassIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentClassIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentClassIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentClassIsMadeUpOfRelationship? left, EquipmentClassIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentClassIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClassIsMadeUpOfRelationship? left, EquipmentClassIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentClassIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}