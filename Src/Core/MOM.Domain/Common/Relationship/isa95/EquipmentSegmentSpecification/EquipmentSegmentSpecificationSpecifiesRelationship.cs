namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification ,Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<EquipmentSegmentSpecificationSpecifiesRelationship>
    {
        public EquipmentSegmentSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public EquipmentSegmentSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationSpecifiesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationSpecifiesRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationSpecifiesRelationship? left, EquipmentSegmentSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationSpecifiesRelationship? left, EquipmentSegmentSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}