namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry>, IEquatable<WorkRecordEntryContainsRelationship>
    {
        public WorkRecordEntryContainsRelationship()
        {
            Name = "contains";
        }

        public WorkRecordEntryContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry source, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordEntryContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordEntryContainsRelationship);
        }

        public bool Equals(WorkRecordEntryContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordEntryContainsRelationship? left, WorkRecordEntryContainsRelationship? right)
        {
            return EqualityComparer<WorkRecordEntryContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordEntryContainsRelationship? left, WorkRecordEntryContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordEntryContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}