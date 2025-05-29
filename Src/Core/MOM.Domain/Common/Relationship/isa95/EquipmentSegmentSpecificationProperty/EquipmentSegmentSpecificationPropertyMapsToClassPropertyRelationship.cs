namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecificationProperty
{
    public class EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}