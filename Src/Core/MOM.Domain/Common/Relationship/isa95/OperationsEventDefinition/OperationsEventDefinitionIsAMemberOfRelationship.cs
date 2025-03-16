namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionIsAMemberOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>, IEquatable<OperationsEventDefinitionIsAMemberOfRelationship>
    {
        public OperationsEventDefinitionIsAMemberOfRelationship()
        {
            Name = "isAMemberOf";
        }

        public OperationsEventDefinitionIsAMemberOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionIsAMemberOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionIsAMemberOfRelationship);
        }

        public bool Equals(OperationsEventDefinitionIsAMemberOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionIsAMemberOfRelationship? left, OperationsEventDefinitionIsAMemberOfRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionIsAMemberOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionIsAMemberOfRelationship? left, OperationsEventDefinitionIsAMemberOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionIsAMemberOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}