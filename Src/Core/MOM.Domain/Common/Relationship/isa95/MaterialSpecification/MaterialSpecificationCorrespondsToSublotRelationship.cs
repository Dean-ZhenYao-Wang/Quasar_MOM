namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialSpecificationCorrespondsToSublotRelationship>
    {
        public MaterialSpecificationCorrespondsToSublotRelationship()
        {
            Name = "correspondsToSublot";
        }

        public MaterialSpecificationCorrespondsToSublotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationCorrespondsToSublotRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationCorrespondsToSublotRelationship);
        }

        public bool Equals(MaterialSpecificationCorrespondsToSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationCorrespondsToSublotRelationship? left, MaterialSpecificationCorrespondsToSublotRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationCorrespondsToSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationCorrespondsToSublotRelationship? left, MaterialSpecificationCorrespondsToSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationCorrespondsToSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}