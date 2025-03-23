namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>, IEquatable<SegmentRequirementContainsEquipmentRelationship>
    {
        public SegmentRequirementContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public SegmentRequirementContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementContainsEquipmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementContainsEquipmentRelationship);
        }

        public bool Equals(SegmentRequirementContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementContainsEquipmentRelationship? left, SegmentRequirementContainsEquipmentRelationship? right)
        {
            return EqualityComparer<SegmentRequirementContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementContainsEquipmentRelationship? left, SegmentRequirementContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}