namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordRecordsActionOnRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry>, IEquatable<OperationsEventRecordRecordsActionOnRelationship>
    {
        public OperationsEventRecordRecordsActionOnRelationship()
        {
            Name = "recordsActionOn";
        }

        public OperationsEventRecordRecordsActionOnRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordRecordsActionOnRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordRecordsActionOnRelationship);
        }

        public bool Equals(OperationsEventRecordRecordsActionOnRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordRecordsActionOnRelationship? left, OperationsEventRecordRecordsActionOnRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordRecordsActionOnRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordRecordsActionOnRelationship? left, OperationsEventRecordRecordsActionOnRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordRecordsActionOnRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}