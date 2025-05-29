namespace MOM.Domain.Common.Relationship.isa95.EquipmentClassProperty
{
    public class EquipmentClassPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentClassPropertyContainsRelationship>
    {
        public EquipmentClassPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentClassPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentClassPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassPropertyContainsRelationship);
        }

        public bool Equals(EquipmentClassPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentClassPropertyContainsRelationship? left, EquipmentClassPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentClassPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClassPropertyContainsRelationship? left, EquipmentClassPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentClassPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}