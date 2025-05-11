namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentClassIncludesPropertiesOfRelationship>
    {
        public EquipmentClassIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public EquipmentClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentClassIncludesPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(EquipmentClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentClassIncludesPropertiesOfRelationship? left, EquipmentClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<EquipmentClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClassIncludesPropertiesOfRelationship? left, EquipmentClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}