namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordSpecifiedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>, IEquatable<OperationsEventRecordSpecifiedByRelationship>
    {
        public OperationsEventRecordSpecifiedByRelationship()
        {
            Name = "specifiedBy";
        }

        public OperationsEventRecordSpecifiedByRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordSpecifiedByRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordSpecifiedByRelationship);
        }

        public bool Equals(OperationsEventRecordSpecifiedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordSpecifiedByRelationship? left, OperationsEventRecordSpecifiedByRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordSpecifiedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordSpecifiedByRelationship? left, OperationsEventRecordSpecifiedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordSpecifiedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}