namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification>, IEquatable<EquipmentSegmentSpecificationIsMadeUpOfRelationship>
    {
        public EquipmentSegmentSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentSegmentSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationIsMadeUpOfRelationship? left, EquipmentSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationIsMadeUpOfRelationship? left, EquipmentSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}