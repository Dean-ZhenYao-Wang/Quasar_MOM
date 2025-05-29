namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification ,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship>
    {
        public EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship()
        {
            Name = "correspondsToEquipmentClass";
        }

        public EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship? left, EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship? left, EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationCorrespondsToEquipmentClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}