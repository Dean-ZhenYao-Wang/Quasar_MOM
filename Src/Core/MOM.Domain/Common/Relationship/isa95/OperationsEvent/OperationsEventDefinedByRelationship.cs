namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition>, IEquatable<OperationsEventDefinedByRelationship>
    {
        public OperationsEventDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public OperationsEventDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinedByRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinedByRelationship);
        }

        public bool Equals(OperationsEventDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinedByRelationship? left, OperationsEventDefinedByRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinedByRelationship? left, OperationsEventDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}