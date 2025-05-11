namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>, IEquatable<MaterialSpecificationIsAssembledFromRelationship>
    {
        public MaterialSpecificationIsAssembledFromRelationship()
        {
            Name = "IsAssembledFrom";
        }

        public MaterialSpecificationIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationIsAssembledFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationIsAssembledFromRelationship);
        }

        public bool Equals(MaterialSpecificationIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationIsAssembledFromRelationship? left, MaterialSpecificationIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationIsAssembledFromRelationship? left, MaterialSpecificationIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}