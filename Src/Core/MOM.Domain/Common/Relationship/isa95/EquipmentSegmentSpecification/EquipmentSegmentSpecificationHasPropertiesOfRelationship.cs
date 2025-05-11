namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty>, IEquatable<EquipmentSegmentSpecificationHasPropertiesOfRelationship>
    {
        public EquipmentSegmentSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public EquipmentSegmentSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationHasPropertiesOfRelationship? left, EquipmentSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationHasPropertiesOfRelationship? left, EquipmentSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}