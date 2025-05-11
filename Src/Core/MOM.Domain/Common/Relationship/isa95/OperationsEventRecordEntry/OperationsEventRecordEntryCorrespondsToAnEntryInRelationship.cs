namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryCorrespondsToAnEntryInRelationship : Relationship<BaseEntity>, IEquatable<OperationsEventRecordEntryCorrespondsToAnEntryInRelationship>
    {
        public OperationsEventRecordEntryCorrespondsToAnEntryInRelationship()
        {
            Name = "correspondsToAnEntryIn";
        }

        public OperationsEventRecordEntryCorrespondsToAnEntryInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordEntryCorrespondsToAnEntryInRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordEntryCorrespondsToAnEntryInRelationship);
        }

        public bool Equals(OperationsEventRecordEntryCorrespondsToAnEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordEntryCorrespondsToAnEntryInRelationship? left, OperationsEventRecordEntryCorrespondsToAnEntryInRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordEntryCorrespondsToAnEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordEntryCorrespondsToAnEntryInRelationship? left, OperationsEventRecordEntryCorrespondsToAnEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordEntryCorrespondsToAnEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}