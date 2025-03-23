namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationCorrespondsToEquipmentClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentSpecificationCorrespondsToEquipmentClassRelationship>
    {
        public EquipmentSpecificationCorrespondsToEquipmentClassRelationship()
        {
            Name = "correspondsToEquipmentClass";
        }

        public EquipmentSpecificationCorrespondsToEquipmentClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationCorrespondsToEquipmentClassRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationCorrespondsToEquipmentClassRelationship);
        }

        public bool Equals(EquipmentSpecificationCorrespondsToEquipmentClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationCorrespondsToEquipmentClassRelationship? left, EquipmentSpecificationCorrespondsToEquipmentClassRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationCorrespondsToEquipmentClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationCorrespondsToEquipmentClassRelationship? left, EquipmentSpecificationCorrespondsToEquipmentClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationCorrespondsToEquipmentClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}