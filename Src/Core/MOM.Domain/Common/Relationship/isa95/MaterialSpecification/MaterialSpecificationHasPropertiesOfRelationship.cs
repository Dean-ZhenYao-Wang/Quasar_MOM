namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty>, IEquatable<MaterialSpecificationHasPropertiesOfRelationship>
    {
        public MaterialSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public MaterialSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(MaterialSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationHasPropertiesOfRelationship? left, MaterialSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationHasPropertiesOfRelationship? left, MaterialSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}