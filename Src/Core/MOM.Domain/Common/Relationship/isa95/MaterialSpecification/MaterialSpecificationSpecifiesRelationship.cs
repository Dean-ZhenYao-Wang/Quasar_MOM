namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<MaterialSpecificationSpecifiesRelationship>
    {
        public MaterialSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public MaterialSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationSpecifiesRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationSpecifiesRelationship);
        }

        public bool Equals(MaterialSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationSpecifiesRelationship? left, MaterialSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationSpecifiesRelationship? left, MaterialSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}