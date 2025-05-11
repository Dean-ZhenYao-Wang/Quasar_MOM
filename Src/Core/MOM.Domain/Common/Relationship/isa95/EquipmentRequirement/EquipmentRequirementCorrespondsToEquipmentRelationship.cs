namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementCorrespondsToEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentRequirementCorrespondsToEquipmentRelationship>
    {
        public EquipmentRequirementCorrespondsToEquipmentRelationship()
        {
            Name = "correspondsToEquipment";
        }

        public EquipmentRequirementCorrespondsToEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementCorrespondsToEquipmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementCorrespondsToEquipmentRelationship);
        }

        public bool Equals(EquipmentRequirementCorrespondsToEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementCorrespondsToEquipmentRelationship? left, EquipmentRequirementCorrespondsToEquipmentRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementCorrespondsToEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementCorrespondsToEquipmentRelationship? left, EquipmentRequirementCorrespondsToEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementCorrespondsToEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}