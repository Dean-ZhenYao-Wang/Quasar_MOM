namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry>, IEquatable<OperationsEventRecordEntryContainsRelationship>
    {
        public OperationsEventRecordEntryContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventRecordEntryContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordEntryContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordEntryContainsRelationship);
        }

        public bool Equals(OperationsEventRecordEntryContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordEntryContainsRelationship? left, OperationsEventRecordEntryContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordEntryContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordEntryContainsRelationship? left, OperationsEventRecordEntryContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordEntryContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}