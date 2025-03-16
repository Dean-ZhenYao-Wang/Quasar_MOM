namespace MOM.Domain.Common.Relationship.isa95.EquipmentProperty
{
    public class EquipmentPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentPropertyContainsRelationship>
    {
        public EquipmentPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentPropertyContainsRelationship);
        }

        public bool Equals(EquipmentPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentPropertyContainsRelationship? left, EquipmentPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentPropertyContainsRelationship? left, EquipmentPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}