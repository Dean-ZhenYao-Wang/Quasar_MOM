namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationCorrespondsToEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentSpecificationCorrespondsToEquipmentRelationship>
    {
        public EquipmentSpecificationCorrespondsToEquipmentRelationship()
        {
            Name = "correspondsToEquipment";
        }

        public EquipmentSpecificationCorrespondsToEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationCorrespondsToEquipmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationCorrespondsToEquipmentRelationship);
        }

        public bool Equals(EquipmentSpecificationCorrespondsToEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationCorrespondsToEquipmentRelationship? left, EquipmentSpecificationCorrespondsToEquipmentRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationCorrespondsToEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationCorrespondsToEquipmentRelationship? left, EquipmentSpecificationCorrespondsToEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationCorrespondsToEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}