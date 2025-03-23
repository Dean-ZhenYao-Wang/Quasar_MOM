namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialSpecificationStorageLocationRelRelationship>
    {
        public MaterialSpecificationStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialSpecificationStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationStorageLocationRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationStorageLocationRelRelationship);
        }

        public bool Equals(MaterialSpecificationStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationStorageLocationRelRelationship? left, MaterialSpecificationStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationStorageLocationRelRelationship? left, MaterialSpecificationStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}