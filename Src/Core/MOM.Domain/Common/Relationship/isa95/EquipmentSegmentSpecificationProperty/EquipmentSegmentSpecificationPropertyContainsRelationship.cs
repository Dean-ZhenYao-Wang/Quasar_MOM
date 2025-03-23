namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty
{
    public class EquipmentSegmentSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty>, IEquatable<EquipmentSegmentSpecificationPropertyContainsRelationship>
    {
        public EquipmentSegmentSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentSegmentSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationPropertyContainsRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationPropertyContainsRelationship? left, EquipmentSegmentSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationPropertyContainsRelationship? left, EquipmentSegmentSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}