namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementCorrespondsToEquipmentClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentRequirementCorrespondsToEquipmentClassRelationship>
    {
        public EquipmentRequirementCorrespondsToEquipmentClassRelationship()
        {
            Name = "correspondsToEquipmentClass";
        }

        public EquipmentRequirementCorrespondsToEquipmentClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementCorrespondsToEquipmentClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementCorrespondsToEquipmentClassRelationship);
        }

        public bool Equals(EquipmentRequirementCorrespondsToEquipmentClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementCorrespondsToEquipmentClassRelationship? left, EquipmentRequirementCorrespondsToEquipmentClassRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementCorrespondsToEquipmentClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementCorrespondsToEquipmentClassRelationship? left, EquipmentRequirementCorrespondsToEquipmentClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementCorrespondsToEquipmentClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}