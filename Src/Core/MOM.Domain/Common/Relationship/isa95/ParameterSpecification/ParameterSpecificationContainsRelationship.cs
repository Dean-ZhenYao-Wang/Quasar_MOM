namespace MOM.Domain.Common.Relationship.isa95.ParameterSpecification
{
    public class ParameterSpecificationContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>, IEquatable<ParameterSpecificationContainsRelationship>
    {
        public ParameterSpecificationContainsRelationship()
        {
            Name = "contains";
        }

        public ParameterSpecificationContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ParameterSpecificationContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ParameterSpecificationContainsRelationship);
        }

        public bool Equals(ParameterSpecificationContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ParameterSpecificationContainsRelationship? left, ParameterSpecificationContainsRelationship? right)
        {
            return EqualityComparer<ParameterSpecificationContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ParameterSpecificationContainsRelationship? left, ParameterSpecificationContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ParameterSpecificationContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}