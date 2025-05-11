namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialSpecificationCorrespondsToClassRelationship>
    {
        public MaterialSpecificationCorrespondsToClassRelationship()
        {
            Name = "correspondsToClass";
        }

        public MaterialSpecificationCorrespondsToClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationCorrespondsToClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationCorrespondsToClassRelationship);
        }

        public bool Equals(MaterialSpecificationCorrespondsToClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationCorrespondsToClassRelationship? left, MaterialSpecificationCorrespondsToClassRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationCorrespondsToClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationCorrespondsToClassRelationship? left, MaterialSpecificationCorrespondsToClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationCorrespondsToClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}