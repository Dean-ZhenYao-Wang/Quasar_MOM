namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>, IEquatable<OperationsSegmentContainsEquipmentRelationship>
    {
        public OperationsSegmentContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public OperationsSegmentContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentContainsEquipmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentContainsEquipmentRelationship);
        }

        public bool Equals(OperationsSegmentContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentContainsEquipmentRelationship? left, OperationsSegmentContainsEquipmentRelationship? right)
        {
            return EqualityComparer<OperationsSegmentContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentContainsEquipmentRelationship? left, OperationsSegmentContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}