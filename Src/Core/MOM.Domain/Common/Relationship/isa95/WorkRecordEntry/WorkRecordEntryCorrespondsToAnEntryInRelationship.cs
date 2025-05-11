namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryCorrespondsToAnEntryInRelationship : Relationship<BaseEntity>, IEquatable<WorkRecordEntryCorrespondsToAnEntryInRelationship>
    {
        public WorkRecordEntryCorrespondsToAnEntryInRelationship()
        {
            Name = "correspondsToAnEntryIn";
        }

        public WorkRecordEntryCorrespondsToAnEntryInRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordEntryCorrespondsToAnEntryInRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordEntryCorrespondsToAnEntryInRelationship);
        }

        public bool Equals(WorkRecordEntryCorrespondsToAnEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordEntryCorrespondsToAnEntryInRelationship? left, WorkRecordEntryCorrespondsToAnEntryInRelationship? right)
        {
            return EqualityComparer<WorkRecordEntryCorrespondsToAnEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordEntryCorrespondsToAnEntryInRelationship? left, WorkRecordEntryCorrespondsToAnEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordEntryCorrespondsToAnEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}