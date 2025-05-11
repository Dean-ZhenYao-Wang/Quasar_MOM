namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualCorrespondsToEquipmentClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentActualCorrespondsToEquipmentClassRelationship>
    {
        public EquipmentActualCorrespondsToEquipmentClassRelationship()
        {
            Name = "correspondsToEquipmentClass";
        }

        public EquipmentActualCorrespondsToEquipmentClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualCorrespondsToEquipmentClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualCorrespondsToEquipmentClassRelationship);
        }

        public bool Equals(EquipmentActualCorrespondsToEquipmentClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualCorrespondsToEquipmentClassRelationship? left, EquipmentActualCorrespondsToEquipmentClassRelationship? right)
        {
            return EqualityComparer<EquipmentActualCorrespondsToEquipmentClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualCorrespondsToEquipmentClassRelationship? left, EquipmentActualCorrespondsToEquipmentClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualCorrespondsToEquipmentClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}