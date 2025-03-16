namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>, IEquatable<OperationsRequestCorrespondsToDefinitionRelationship>
    {
        public OperationsRequestCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public OperationsRequestCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRequestCorrespondsToDefinitionRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRequestCorrespondsToDefinitionRelationship);
        }

        public bool Equals(OperationsRequestCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRequestCorrespondsToDefinitionRelationship? left, OperationsRequestCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<OperationsRequestCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRequestCorrespondsToDefinitionRelationship? left, OperationsRequestCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRequestCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}