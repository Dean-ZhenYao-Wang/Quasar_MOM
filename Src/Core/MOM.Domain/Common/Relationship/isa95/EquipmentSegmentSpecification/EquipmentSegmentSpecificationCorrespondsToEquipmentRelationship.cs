namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship>
    {
        public EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship()
        {
            Name = "correspondsToEquipment";
        }

        public EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship? left, EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship? left, EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationCorrespondsToEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}