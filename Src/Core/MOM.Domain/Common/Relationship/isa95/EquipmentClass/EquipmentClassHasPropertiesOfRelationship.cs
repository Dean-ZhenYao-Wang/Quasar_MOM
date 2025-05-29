namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass ,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentClassHasPropertiesOfRelationship>
    {
        public EquipmentClassHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public EquipmentClassHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentClassHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassHasPropertiesOfRelationship);
        }

        public bool Equals(EquipmentClassHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentClassHasPropertiesOfRelationship? left, EquipmentClassHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<EquipmentClassHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClassHasPropertiesOfRelationship? left, EquipmentClassHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentClassHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}