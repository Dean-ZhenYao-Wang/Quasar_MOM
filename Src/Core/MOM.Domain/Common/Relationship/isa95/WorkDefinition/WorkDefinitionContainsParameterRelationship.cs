namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsParameterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>, IEquatable<WorkDefinitionContainsParameterRelationship>
    {
        public WorkDefinitionContainsParameterRelationship()
        {
            Name = "containsParameter";
        }

        public WorkDefinitionContainsParameterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionContainsParameterRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionContainsParameterRelationship);
        }

        public bool Equals(WorkDefinitionContainsParameterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionContainsParameterRelationship? left, WorkDefinitionContainsParameterRelationship? right)
        {
            return EqualityComparer<WorkDefinitionContainsParameterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionContainsParameterRelationship? left, WorkDefinitionContainsParameterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionContainsParameterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}