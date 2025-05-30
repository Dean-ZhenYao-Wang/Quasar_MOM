namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification ,Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>, IEquatable<EquipmentSpecificationIsMadeUpOfRelationship>
    {
        public EquipmentSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public EquipmentSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(EquipmentSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationIsMadeUpOfRelationship? left, EquipmentSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationIsMadeUpOfRelationship? left, EquipmentSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}