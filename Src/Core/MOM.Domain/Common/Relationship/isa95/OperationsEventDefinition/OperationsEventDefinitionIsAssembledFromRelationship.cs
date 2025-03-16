namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition>, IEquatable<OperationsEventDefinitionIsAssembledFromRelationship>
    {
        public OperationsEventDefinitionIsAssembledFromRelationship()
        {
            Name = "isAssembledFrom";
        }

        public OperationsEventDefinitionIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionIsAssembledFromRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionIsAssembledFromRelationship);
        }

        public bool Equals(OperationsEventDefinitionIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionIsAssembledFromRelationship? left, OperationsEventDefinitionIsAssembledFromRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionIsAssembledFromRelationship? left, OperationsEventDefinitionIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}