namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<EquipmentSpecificationSpecifiesRelationship>
    {
        public EquipmentSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public EquipmentSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationSpecifiesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationSpecifiesRelationship);
        }

        public bool Equals(EquipmentSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationSpecifiesRelationship? left, EquipmentSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationSpecifiesRelationship? left, EquipmentSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}