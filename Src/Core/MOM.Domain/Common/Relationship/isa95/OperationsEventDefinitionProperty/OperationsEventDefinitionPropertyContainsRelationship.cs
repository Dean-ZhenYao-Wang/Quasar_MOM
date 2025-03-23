namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionProperty
{
    public class OperationsEventDefinitionPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>, IEquatable<OperationsEventDefinitionPropertyContainsRelationship>
    {
        public OperationsEventDefinitionPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventDefinitionPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionPropertyContainsRelationship);
        }

        public bool Equals(OperationsEventDefinitionPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionPropertyContainsRelationship? left, OperationsEventDefinitionPropertyContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionPropertyContainsRelationship? left, OperationsEventDefinitionPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}