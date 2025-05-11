namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsDefinitionContainsRelationship>
    {
        public OperationsDefinitionContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsDefinitionContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsDefinitionContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsDefinitionContainsRelationship);
        }

        public bool Equals(OperationsDefinitionContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsDefinitionContainsRelationship? left, OperationsDefinitionContainsRelationship? right)
        {
            return EqualityComparer<OperationsDefinitionContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsDefinitionContainsRelationship? left, OperationsDefinitionContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsDefinitionContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}