namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord>, IEquatable<OperationsEventRecordContainsRelationship>
    {
        public OperationsEventRecordContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventRecordContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordContainsRelationship);
        }

        public bool Equals(OperationsEventRecordContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordContainsRelationship? left, OperationsEventRecordContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordContainsRelationship? left, OperationsEventRecordContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}