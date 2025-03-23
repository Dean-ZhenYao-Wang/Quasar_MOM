namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryCorrespondsToAnExternalEntryInRelationship : Relationship<BaseEntity>, IEquatable<WorkRecordEntryCorrespondsToAnExternalEntryInRelationship>
    {
        public WorkRecordEntryCorrespondsToAnExternalEntryInRelationship()
        {
            Name = "correspondsToAnExternalEntryIn";
        }

        public WorkRecordEntryCorrespondsToAnExternalEntryInRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordEntryCorrespondsToAnExternalEntryInRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordEntryCorrespondsToAnExternalEntryInRelationship);
        }

        public bool Equals(WorkRecordEntryCorrespondsToAnExternalEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordEntryCorrespondsToAnExternalEntryInRelationship? left, WorkRecordEntryCorrespondsToAnExternalEntryInRelationship? right)
        {
            return EqualityComparer<WorkRecordEntryCorrespondsToAnExternalEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordEntryCorrespondsToAnExternalEntryInRelationship? left, WorkRecordEntryCorrespondsToAnExternalEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordEntryCorrespondsToAnExternalEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}