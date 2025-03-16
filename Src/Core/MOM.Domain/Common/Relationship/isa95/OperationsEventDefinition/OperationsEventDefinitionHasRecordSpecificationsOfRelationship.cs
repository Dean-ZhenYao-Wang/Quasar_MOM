namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHasRecordSpecificationsOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>, IEquatable<OperationsEventDefinitionHasRecordSpecificationsOfRelationship>
    {
        public OperationsEventDefinitionHasRecordSpecificationsOfRelationship()
        {
            Name = "hasRecordSpecificationsOf";
        }

        public OperationsEventDefinitionHasRecordSpecificationsOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionHasRecordSpecificationsOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionHasRecordSpecificationsOfRelationship);
        }

        public bool Equals(OperationsEventDefinitionHasRecordSpecificationsOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionHasRecordSpecificationsOfRelationship? left, OperationsEventDefinitionHasRecordSpecificationsOfRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionHasRecordSpecificationsOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionHasRecordSpecificationsOfRelationship? left, OperationsEventDefinitionHasRecordSpecificationsOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionHasRecordSpecificationsOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}