namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<EquipmentSegmentSpecificationOperationalLocationRelRelationship>
    {
        public EquipmentSegmentSpecificationOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public EquipmentSegmentSpecificationOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationOperationalLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationOperationalLocationRelRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationOperationalLocationRelRelationship? left, EquipmentSegmentSpecificationOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationOperationalLocationRelRelationship? left, EquipmentSegmentSpecificationOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}